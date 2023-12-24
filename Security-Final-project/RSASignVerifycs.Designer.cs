namespace Security_Final_project
{
    partial class RSASignVerifycs
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
            Choosebtn = new Button();
            ClearResultbtn = new Button();
            ClearDatabtn = new Button();
            Verifybtn = new Button();
            Signbtn = new Button();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            groupBox2 = new GroupBox();
            richTextBox2 = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 504);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Choosebtn
            // 
            Choosebtn.Dock = DockStyle.Fill;
            Choosebtn.Location = new Point(3, 3);
            Choosebtn.Name = "Choosebtn";
            Choosebtn.Size = new Size(234, 41);
            Choosebtn.TabIndex = 0;
            Choosebtn.Text = "Choose Input File";
            Choosebtn.UseVisualStyleBackColor = true;
            Choosebtn.Click += Choosebtn_Click;
            // 
            // ClearResultbtn
            // 
            ClearResultbtn.Dock = DockStyle.Fill;
            ClearResultbtn.Location = new Point(3, 191);
            ClearResultbtn.Name = "ClearResultbtn";
            ClearResultbtn.Size = new Size(234, 45);
            ClearResultbtn.TabIndex = 4;
            ClearResultbtn.Text = "Clear Result";
            ClearResultbtn.UseVisualStyleBackColor = true;
            ClearResultbtn.Click += ClearResultbtn_Click;
            // 
            // ClearDatabtn
            // 
            ClearDatabtn.Dock = DockStyle.Fill;
            ClearDatabtn.Location = new Point(3, 144);
            ClearDatabtn.Name = "ClearDatabtn";
            ClearDatabtn.Size = new Size(234, 41);
            ClearDatabtn.TabIndex = 3;
            ClearDatabtn.Text = "Clear Data";
            ClearDatabtn.UseVisualStyleBackColor = true;
            ClearDatabtn.Click += ClearDatabtn_Click;
            // 
            // Verifybtn
            // 
            Verifybtn.Dock = DockStyle.Fill;
            Verifybtn.Location = new Point(3, 97);
            Verifybtn.Name = "Verifybtn";
            Verifybtn.Size = new Size(234, 41);
            Verifybtn.TabIndex = 2;
            Verifybtn.Text = "Verify";
            Verifybtn.UseVisualStyleBackColor = true;
            Verifybtn.Click += Verifybtn_Click;
            // 
            // Signbtn
            // 
            Signbtn.Dock = DockStyle.Fill;
            Signbtn.Location = new Point(3, 50);
            Signbtn.Name = "Signbtn";
            Signbtn.Size = new Size(234, 41);
            Signbtn.TabIndex = 1;
            Signbtn.Text = "Sign";
            Signbtn.UseVisualStyleBackColor = true;
            Signbtn.Click += Signbtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(240, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(619, 504);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(619, 504);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 498);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input Data";
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(3, 23);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(297, 472);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(312, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(304, 498);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Result";
            // 
            // richTextBox2
            // 
            richTextBox2.Dock = DockStyle.Fill;
            richTextBox2.Location = new Point(3, 23);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(298, 472);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Choosebtn, 0, 0);
            tableLayoutPanel1.Controls.Add(ClearResultbtn, 0, 4);
            tableLayoutPanel1.Controls.Add(Signbtn, 0, 1);
            tableLayoutPanel1.Controls.Add(ClearDatabtn, 0, 3);
            tableLayoutPanel1.Controls.Add(Verifybtn, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(240, 239);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // RSASignVerifycs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(859, 504);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "RSASignVerifycs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RSASignVerifycs";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button ClearDatabtn;
        private Button Verifybtn;
        private Button Choosebtn;
        private Button Signbtn;
        private TableLayoutPanel tableLayoutPanel3;
        private Button ClearResultbtn;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
        private GroupBox groupBox2;
        private RichTextBox richTextBox2;
        private TableLayoutPanel tableLayoutPanel1;
    }
}