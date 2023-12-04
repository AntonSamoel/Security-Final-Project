namespace Security_Final_project
{
	partial class MainForm
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
			groupBox1 = new GroupBox();
			signOption = new RadioButton();
			rsaOption = new RadioButton();
			nextButton = new Button();
			encAndDecOption = new RadioButton();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(signOption);
			groupBox1.Controls.Add(rsaOption);
			groupBox1.Controls.Add(nextButton);
			groupBox1.Controls.Add(encAndDecOption);
			groupBox1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
			groupBox1.Location = new Point(35, 61);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(1176, 555);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Choose one of the three options:";
			// 
			// signOption
			// 
			signOption.AutoSize = true;
			signOption.Location = new Point(24, 279);
			signOption.Name = "signOption";
			signOption.Size = new Size(324, 50);
			signOption.TabIndex = 3;
			signOption.TabStop = true;
			signOption.Text = "Encrypt And Sign";
			signOption.UseVisualStyleBackColor = true;
			signOption.CheckedChanged += signOption_CheckedChanged;
			// 
			// rsaOption
			// 
			rsaOption.AutoSize = true;
			rsaOption.Location = new Point(24, 181);
			rsaOption.Name = "rsaOption";
			rsaOption.Size = new Size(119, 50);
			rsaOption.TabIndex = 2;
			rsaOption.TabStop = true;
			rsaOption.Text = "RSA";
			rsaOption.UseVisualStyleBackColor = true;
			rsaOption.CheckedChanged += rsaOption_CheckedChanged;
			// 
			// nextButton
			// 
			nextButton.Location = new Point(927, 461);
			nextButton.Name = "nextButton";
			nextButton.Size = new Size(205, 60);
			nextButton.TabIndex = 1;
			nextButton.Text = "Next";
			nextButton.UseVisualStyleBackColor = true;
			nextButton.Click += nextButton_Click;
			// 
			// encAndDecOption
			// 
			encAndDecOption.AutoSize = true;
			encAndDecOption.Location = new Point(24, 83);
			encAndDecOption.Name = "encAndDecOption";
			encAndDecOption.Size = new Size(454, 50);
			encAndDecOption.TabIndex = 0;
			encAndDecOption.TabStop = true;
			encAndDecOption.Text = "Encrypt and Decrypt Files";
			encAndDecOption.UseVisualStyleBackColor = true;
			encAndDecOption.CheckedChanged += radioButton1_CheckedChanged;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(17F, 34F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1277, 654);
			Controls.Add(groupBox1);
			Font = new Font("Times New Roman", 18F);
			Margin = new Padding(6, 5, 6, 5);
			Name = "MainForm";
			Text = "Security";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private GroupBox groupBox1;
		private RadioButton encAndDecOption;
		private Button nextButton;
		private RadioButton signOption;
		private RadioButton rsaOption;
	}
}