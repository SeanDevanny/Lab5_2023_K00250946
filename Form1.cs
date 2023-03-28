using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_2023_K00250946
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Create a new dictionary to store the csv data
        private Dictionary<string, string> csvData = new Dictionary<string, string>();
        // Create a new task so other processes can wait for it to finish
        private Task loadCsvTask = null;
        // Mode select
        private bool mode = true;
        private string originalText = string.Empty;
        private string newText = string.Empty;
        private async void LoadCSVButton_Click(object sender, EventArgs e)
        {
            // If the loadCsvTask is already running, wait for it to finish
            if (loadCsvTask != null && !loadCsvTask.IsCompleted)
            {
                await loadCsvTask;
            }
            // Create a new instance of OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter to only show .csv files
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";

            // Show the dialog and check if the user clicked OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //re-setting csvdata
                csvData = new Dictionary<string, string>();
                // Read the contents of the csv file in a separate thread
                loadCsvTask = Task.Run(() =>
                {
                    try
                    {
                        using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                        {
                            // Loop through each line of the csv file
                            while (!reader.EndOfStream)
                            {
                                // Split the line into columns
                                string[] columns = reader.ReadLine().Split(',');

                                // Add the data to the dictionary
                                csvData.Add(columns[0], columns[1]);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                });
                await loadCsvTask;
                //display data in a DataGridView
                dataGridView1.DataSource = csvData.ToList();
                dataGridView1.Columns["Key"].HeaderText = "English";
                dataGridView1.Columns["Value"].HeaderText = "American";
                modeDisplayLabel.Visible = true;
                modeLabel.Visible = true;
                invertButton.Enabled = true;
            }
        }

        private async void modifyTextButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter to only show text files
            openFileDialog.Filter = "Text files (*.txt)|*.txt";

            // Show the dialog and check if the user clicked OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                newTextBox.Clear();
                originalTextBox.Clear();
                // Grab filepath so it can't be changed by multithreadded processes or anything else
                string filePath = openFileDialog.FileName;

                // Get the directory path of the selected file
                string directoryPath = Path.GetDirectoryName(filePath);
                // Get the file name of the selected file
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                // Get the extension
                string extention = Path.GetExtension(filePath);
                // Create a new file path for the modified copy of the file
                string modifiedFilePath;
                for (int i = 1; true; ++i)
                {
                    modifiedFilePath = Path.Combine(directoryPath, $"{fileName}({i}){extention}");
                    if (!File.Exists(modifiedFilePath))
                    {
                        break;
                    }
                }
                // If the loadCsvTask is already running, wait for it to finish
                if (loadCsvTask != null && !loadCsvTask.IsCompleted)
                {
                    await loadCsvTask;
                }
                // disable mode toggle so it doesn't mess with translation
                invertButton.Enabled = false;
                //note: any text writing done here will not update until process is finished because an invoke wasn't used.
                //This runs fast enough that it's not noticable and so an invoke is not needed
                await Task.Run(() =>
                {
                    // Open the text file for reading
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        // Create a new stream writer for the modified copy of the file
                        using (StreamWriter writer = new StreamWriter(modifiedFilePath))
                        {
                            // Read the file line by line
                            string line;
                            originalText = string.Empty;
                            newText = string.Empty;
                            while ((line = reader.ReadLine()) != null)
                            {
                                //write it out to textbox
                                originalText += line + "\r";
                                // Split the line into words
                                string[] words = line.Split(' ');

                                for (int i = 0; i < words.Length; i++)
                                {
                                    if (mode)
                                    {
                                        if (csvData.ContainsKey(words[i]))
                                        {
                                            words[i] = csvData[words[i]];
                                        }
                                    }
                                    else
                                    {
                                        if (csvData.ContainsValue(words[i]))
                                        {
                                            words[i] = csvData.FirstOrDefault(x => x.Value == words[i]).Key;
                                        }
                                    }

                                }

                                // Join the words back together and write the modified line to the new file and to textbox
                                string modifiedLine = string.Join(" ", words);
                                newText += modifiedLine + "\r";
                                writer.WriteLine(modifiedLine);
                            }
                        }
                    }
                });
                //if no data iś grid, don't re-enable button
                if (dataGridView1.ColumnCount != 0)
                {
                    //re-enable invert button
                    invertButton.Enabled = true;
                }
                originalTextBox.Text = originalText;
                newTextBox.Text = newText;
            }
        }

        private void invertButton_Click(object sender, EventArgs e)
        {
            //toggle mode button
            mode = !mode;
            updateModeUI(mode);
        }

        private void updateModeUI(bool m)
        {
            if (m)
            {
                dataGridView1.Columns["Key"].DisplayIndex = 0;
                dataGridView1.Columns["Value"].DisplayIndex = 1;
                modeDisplayLabel.Text = "English -> American";
            }
            else
            {
                dataGridView1.Columns["Key"].DisplayIndex = 1;
                dataGridView1.Columns["Value"].DisplayIndex = 0;
                modeDisplayLabel.Text = "American -> English";
            }
        }
    }
}
