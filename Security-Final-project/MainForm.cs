using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security_Final_project
{
    public partial class MainForm : Form
    {
        private string choice = string.Empty;
        public MainForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (encAndDecOption.Checked)
            {
                choice = "option 1";
            }
        }

        private void rsaOption_CheckedChanged(object sender, EventArgs e)
        {
            if (rsaOption.Checked)
            {
                choice = "option 2";
            }
        }

        private void signOption_CheckedChanged(object sender, EventArgs e)
        {
            if (signOption.Checked)
            {
                choice = "option 3";
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            switch (choice)
            {
                case "option 1":
                    var encAndDecForm = new EncAndDec();
                    encAndDecForm.ShowDialog();
                    break;
                case "option 2":
                    RSASignVerifycs rSASignVerifycs = new();
                    rSASignVerifycs.ShowDialog();
                    break;
                case "option 3":
                    ConfienAndAuthen confienAndAuthen = new();
                    confienAndAuthen.ShowDialog();
                    break;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
