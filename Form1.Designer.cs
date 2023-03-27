namespace Lab5_2023_K00250946
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadCSVButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DictionaryTitleLabel = new System.Windows.Forms.Label();
            this.modifyTextButton = new System.Windows.Forms.Button();
            this.originalTextBox = new System.Windows.Forms.RichTextBox();
            this.newTextBox = new System.Windows.Forms.RichTextBox();
            this.originalFileLabel = new System.Windows.Forms.Label();
            this.newFileLabel = new System.Windows.Forms.Label();
            this.invertButton = new System.Windows.Forms.Button();
            this.modeLabel = new System.Windows.Forms.Label();
            this.modeDisplayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadCSVButton
            // 
            this.LoadCSVButton.Location = new System.Drawing.Point(12, 415);
            this.LoadCSVButton.Name = "LoadCSVButton";
            this.LoadCSVButton.Size = new System.Drawing.Size(96, 23);
            this.LoadCSVButton.TabIndex = 0;
            this.LoadCSVButton.Text = "Upload CSV";
            this.LoadCSVButton.UseVisualStyleBackColor = true;
            this.LoadCSVButton.Click += new System.EventHandler(this.LoadCSVButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(198, 356);
            this.dataGridView1.TabIndex = 1;
            // 
            // DictionaryTitleLabel
            // 
            this.DictionaryTitleLabel.AutoSize = true;
            this.DictionaryTitleLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DictionaryTitleLabel.Location = new System.Drawing.Point(9, 14);
            this.DictionaryTitleLabel.Name = "DictionaryTitleLabel";
            this.DictionaryTitleLabel.Size = new System.Drawing.Size(177, 25);
            this.DictionaryTitleLabel.TabIndex = 2;
            this.DictionaryTitleLabel.Text = "Dictionary in use :";
            // 
            // modifyTextButton
            // 
            this.modifyTextButton.Location = new System.Drawing.Point(225, 415);
            this.modifyTextButton.Name = "modifyTextButton";
            this.modifyTextButton.Size = new System.Drawing.Size(163, 22);
            this.modifyTextButton.TabIndex = 3;
            this.modifyTextButton.Text = "Upload Text File to Modify";
            this.modifyTextButton.UseVisualStyleBackColor = true;
            this.modifyTextButton.Click += new System.EventHandler(this.modifyTextButton_Click);
            // 
            // originalTextBox
            // 
            this.originalTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.originalTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.originalTextBox.Location = new System.Drawing.Point(225, 53);
            this.originalTextBox.Name = "originalTextBox";
            this.originalTextBox.ReadOnly = true;
            this.originalTextBox.Size = new System.Drawing.Size(258, 356);
            this.originalTextBox.TabIndex = 4;
            this.originalTextBox.Text = "";
            // 
            // newTextBox
            // 
            this.newTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.newTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.newTextBox.Location = new System.Drawing.Point(489, 53);
            this.newTextBox.Name = "newTextBox";
            this.newTextBox.ReadOnly = true;
            this.newTextBox.Size = new System.Drawing.Size(258, 356);
            this.newTextBox.TabIndex = 5;
            this.newTextBox.Text = "";
            // 
            // originalFileLabel
            // 
            this.originalFileLabel.AutoSize = true;
            this.originalFileLabel.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalFileLabel.Location = new System.Drawing.Point(221, 18);
            this.originalFileLabel.Name = "originalFileLabel";
            this.originalFileLabel.Size = new System.Drawing.Size(99, 21);
            this.originalFileLabel.TabIndex = 6;
            this.originalFileLabel.Text = "Original File\r\n";
            // 
            // newFileLabel
            // 
            this.newFileLabel.AutoSize = true;
            this.newFileLabel.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newFileLabel.Location = new System.Drawing.Point(485, 18);
            this.newFileLabel.Name = "newFileLabel";
            this.newFileLabel.Size = new System.Drawing.Size(73, 21);
            this.newFileLabel.TabIndex = 7;
            this.newFileLabel.Text = "New File";
            // 
            // invertButton
            // 
            this.invertButton.Enabled = false;
            this.invertButton.Location = new System.Drawing.Point(114, 414);
            this.invertButton.Name = "invertButton";
            this.invertButton.Size = new System.Drawing.Size(96, 23);
            this.invertButton.TabIndex = 8;
            this.invertButton.Text = "Invert";
            this.invertButton.UseVisualStyleBackColor = true;
            this.invertButton.Click += new System.EventHandler(this.invertButton_Click);
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new System.Drawing.Point(486, 424);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(37, 13);
            this.modeLabel.TabIndex = 10;
            this.modeLabel.Text = "Mode:";
            this.modeLabel.Visible = false;
            // 
            // modeDisplayLabel
            // 
            this.modeDisplayLabel.AutoSize = true;
            this.modeDisplayLabel.Location = new System.Drawing.Point(529, 424);
            this.modeDisplayLabel.Name = "modeDisplayLabel";
            this.modeDisplayLabel.Size = new System.Drawing.Size(100, 13);
            this.modeDisplayLabel.TabIndex = 11;
            this.modeDisplayLabel.Text = "English -> American";
            this.modeDisplayLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modeDisplayLabel);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.invertButton);
            this.Controls.Add(this.newFileLabel);
            this.Controls.Add(this.originalFileLabel);
            this.Controls.Add(this.newTextBox);
            this.Controls.Add(this.originalTextBox);
            this.Controls.Add(this.modifyTextButton);
            this.Controls.Add(this.DictionaryTitleLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LoadCSVButton);
            this.Name = "Form1";
            this.Text = "English to American Translator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadCSVButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label DictionaryTitleLabel;
        private System.Windows.Forms.Button modifyTextButton;
        private System.Windows.Forms.RichTextBox originalTextBox;
        private System.Windows.Forms.RichTextBox newTextBox;
        private System.Windows.Forms.Label originalFileLabel;
        private System.Windows.Forms.Label newFileLabel;
        private System.Windows.Forms.Button invertButton;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.Label modeDisplayLabel;
    }
}

