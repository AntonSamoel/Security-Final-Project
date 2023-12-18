namespace Security_Final_project
{
    partial class ConfienAndAuthen
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
			panel1 = new Panel();
			tableLayoutPanel1 = new TableLayoutPanel();
			button5 = new Button();
			button4 = new Button();
			button3 = new Button();
			button2 = new Button();
			button1 = new Button();
			panel2 = new Panel();
			tableLayoutPanel2 = new TableLayoutPanel();
			groupBox2 = new GroupBox();
			richTextBox2 = new RichTextBox();
			groupBox1 = new GroupBox();
			richTextBox1 = new RichTextBox();
			panel1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			panel2.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(224, 224, 224);
			panel1.Controls.Add(tableLayoutPanel1);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(250, 587);
			panel1.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(button5, 0, 4);
			tableLayoutPanel1.Controls.Add(button4, 0, 3);
			tableLayoutPanel1.Controls.Add(button3, 0, 2);
			tableLayoutPanel1.Controls.Add(button2, 0, 1);
			tableLayoutPanel1.Controls.Add(button1, 0, 0);
			tableLayoutPanel1.Dock = DockStyle.Top;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 5;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.Size = new Size(250, 298);
			tableLayoutPanel1.TabIndex = 1;
			// 
			// button5
			// 
			button5.Dock = DockStyle.Fill;
			button5.Location = new Point(3, 239);
			button5.Name = "button5";
			button5.Size = new Size(244, 56);
			button5.TabIndex = 5;
			button5.Text = "Clear Result";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// button4
			// 
			button4.Dock = DockStyle.Fill;
			button4.Location = new Point(3, 180);
			button4.Name = "button4";
			button4.Size = new Size(244, 53);
			button4.TabIndex = 4;
			button4.Text = "Clear Input Data";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button3
			// 
			button3.Dock = DockStyle.Fill;
			button3.Location = new Point(3, 121);
			button3.Name = "button3";
			button3.Size = new Size(244, 53);
			button3.TabIndex = 3;
			button3.Text = "Decrypt and Verify";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button2
			// 
			button2.Dock = DockStyle.Fill;
			button2.Location = new Point(3, 62);
			button2.Name = "button2";
			button2.Size = new Size(244, 53);
			button2.TabIndex = 2;
			button2.Text = "Sign and Encrypt";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Dock = DockStyle.Fill;
			button1.Location = new Point(3, 3);
			button1.Name = "button1";
			button1.Size = new Size(244, 53);
			button1.TabIndex = 1;
			button1.Text = "Choose File";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// panel2
			// 
			panel2.Controls.Add(tableLayoutPanel2);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(250, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(763, 587);
			panel2.TabIndex = 1;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(groupBox2, 1, 0);
			tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(0, 0);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(763, 587);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(richTextBox2);
			groupBox2.Dock = DockStyle.Fill;
			groupBox2.Location = new Point(384, 3);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(376, 581);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "Result";
			// 
			// richTextBox2
			// 
			richTextBox2.Dock = DockStyle.Fill;
			richTextBox2.Location = new Point(3, 23);
			richTextBox2.Name = "richTextBox2";
			richTextBox2.Size = new Size(370, 555);
			richTextBox2.TabIndex = 1;
			richTextBox2.Text = "";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(richTextBox1);
			groupBox1.Dock = DockStyle.Fill;
			groupBox1.Location = new Point(3, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(375, 581);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Input Data";
			// 
			// richTextBox1
			// 
			richTextBox1.Dock = DockStyle.Fill;
			richTextBox1.Location = new Point(3, 23);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(369, 555);
			richTextBox1.TabIndex = 0;
			richTextBox1.Text = "";
			// 
			// ConfienAndAuthen
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1013, 587);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "ConfienAndAuthen";
			Text = "ConfienAndAuthen";
			panel1.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox2;
        private RichTextBox richTextBox2;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
    }
}