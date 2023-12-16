namespace Security_Final_project
{
	partial class EncAndDec
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chooseFileButton = new Button();
            inputDataRichTextBox = new RichTextBox();
            EncryptButton = new Button();
            saveToFile = new Button();
            decryptButton = new Button();
            ShowResultRichTextBox = new RichTextBox();
            inputDataButton = new Label();
            resultButton = new Label();
            clearResultButton = new Button();
            clearDataButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // chooseFileButton
            // 
            chooseFileButton.AccessibleName = "";
            chooseFileButton.Location = new Point(38, 95);
            chooseFileButton.Margin = new Padding(6, 5, 6, 5);
            chooseFileButton.Name = "chooseFileButton";
            chooseFileButton.Size = new Size(253, 49);
            chooseFileButton.TabIndex = 1;
            chooseFileButton.Text = "Choose File ";
            chooseFileButton.UseVisualStyleBackColor = true;
            chooseFileButton.Click += chooseFileButton_Click;
            // 
            // inputDataRichTextBox
            // 
            inputDataRichTextBox.BackColor = Color.FromArgb(224, 224, 224);
            inputDataRichTextBox.Location = new Point(323, 95);
            inputDataRichTextBox.Name = "inputDataRichTextBox";
            inputDataRichTextBox.ReadOnly = true;
            inputDataRichTextBox.Size = new Size(899, 216);
            inputDataRichTextBox.TabIndex = 2;
            inputDataRichTextBox.Text = "";
            // 
            // EncryptButton
            // 
            EncryptButton.Location = new Point(38, 203);
            EncryptButton.Name = "EncryptButton";
            EncryptButton.Size = new Size(253, 51);
            EncryptButton.TabIndex = 3;
            EncryptButton.Text = "Encrypt The Data";
            EncryptButton.UseVisualStyleBackColor = true;
            EncryptButton.Click += EncryptButton_Click;
            // 
            // saveToFile
            // 
            saveToFile.Location = new Point(23, 549);
            saveToFile.Name = "saveToFile";
            saveToFile.Size = new Size(253, 41);
            saveToFile.TabIndex = 4;
            saveToFile.Text = "Save To File";
            saveToFile.UseVisualStyleBackColor = true;
            saveToFile.Click += saveToFile_Click;
            // 
            // decryptButton
            // 
            decryptButton.Location = new Point(38, 261);
            decryptButton.Name = "decryptButton";
            decryptButton.Size = new Size(253, 50);
            decryptButton.TabIndex = 5;
            decryptButton.Text = "Decrypt The Data";
            decryptButton.UseVisualStyleBackColor = true;
            decryptButton.Click += decryptButton_Click;
            // 
            // ShowResultRichTextBox
            // 
            ShowResultRichTextBox.BackColor = Color.FromArgb(224, 224, 224);
            ShowResultRichTextBox.Location = new Point(323, 362);
            ShowResultRichTextBox.Name = "ShowResultRichTextBox";
            ShowResultRichTextBox.ReadOnly = true;
            ShowResultRichTextBox.Size = new Size(899, 228);
            ShowResultRichTextBox.TabIndex = 6;
            ShowResultRichTextBox.Text = "";
            // 
            // inputDataButton
            // 
            inputDataButton.AutoSize = true;
            inputDataButton.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputDataButton.Location = new Point(323, 44);
            inputDataButton.Name = "inputDataButton";
            inputDataButton.Size = new Size(160, 39);
            inputDataButton.TabIndex = 7;
            inputDataButton.Text = "Input Data";
            // 
            // resultButton
            // 
            resultButton.AutoSize = true;
            resultButton.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultButton.Location = new Point(323, 314);
            resultButton.Name = "resultButton";
            resultButton.Size = new Size(103, 39);
            resultButton.TabIndex = 8;
            resultButton.Text = "Result";
            // 
            // clearResultButton
            // 
            clearResultButton.Location = new Point(23, 488);
            clearResultButton.Name = "clearResultButton";
            clearResultButton.Size = new Size(253, 46);
            clearResultButton.TabIndex = 9;
            clearResultButton.Text = "Clear Result";
            clearResultButton.UseVisualStyleBackColor = true;
            clearResultButton.Click += clearResultButton_Click;
            // 
            // clearDataButton
            // 
            clearDataButton.Location = new Point(38, 317);
            clearDataButton.Name = "clearDataButton";
            clearDataButton.Size = new Size(253, 46);
            clearDataButton.TabIndex = 10;
            clearDataButton.Text = "Clear Data";
            clearDataButton.UseVisualStyleBackColor = true;
            clearDataButton.Click += clearDataButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(38, 152);
            button1.Name = "button1";
            button1.Size = new Size(253, 45);
            button1.TabIndex = 11;
            button1.Text = "Choose Key";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EncAndDec
            // 
            AutoScaleDimensions = new SizeF(17F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 648);
            Controls.Add(button1);
            Controls.Add(clearDataButton);
            Controls.Add(clearResultButton);
            Controls.Add(resultButton);
            Controls.Add(inputDataButton);
            Controls.Add(ShowResultRichTextBox);
            Controls.Add(decryptButton);
            Controls.Add(saveToFile);
            Controls.Add(EncryptButton);
            Controls.Add(inputDataRichTextBox);
            Controls.Add(chooseFileButton);
            Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "EncAndDec";
            Text = "Security";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button chooseFileButton;
		private RichTextBox inputDataRichTextBox;
		private Button EncryptButton;
		private Button saveToFile;
		private Button decryptButton;
		private RichTextBox ShowResultRichTextBox;
		private Label inputDataButton;
		private Label resultButton;
		private Button clearResultButton;
		private Button clearDataButton;
        private Button button1;
    }
}
