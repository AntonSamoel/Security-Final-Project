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
    public partial class ConfienAndAuthen : Form
    {
        ConfidentialityAndAuthentication conAndAuth = new();
        public ConfienAndAuthen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text files (*.txt) | *.txt";
                var result = openFileDialog.ShowDialog();
				if (DialogResult.Cancel == result)
				{
					MessageBox.Show("Operation canceled by the user", "Canceled");
				}
                else
                {
					using (StreamReader reader = new StreamReader(openFileDialog.FileName))
					{
						richTextBox1.Text = reader.ReadToEnd();
					}
				}
				
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
                // richTextBox1.Text = "No Data To Show";
                MessageBox.Show("Input Data is empty");
            }
            else
            {
                string enc = conAndAuth.SignAndEncrypt(richTextBox1.Text);
                richTextBox2.Text = enc;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text.Length == 0)
            {
                //richTextBox2.Text = "Result is Empty";
                MessageBox.Show("Result is empty");
            }
            else
            {
                if (conAndAuth.IsDecryptedAndVerified(richTextBox2.Text))
                {
                    string[] data = conAndAuth.DecryptAndVerify(richTextBox2.Text);

                    richTextBox2.Text = data[0] + "\nSIGNETURE\n" + data[1];

                    richTextBox2.Text += "\n\t Verified Successfully\n";
                }
                else
                {
                    richTextBox2.Text = "Decryption and Verification Failed !!!";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = String.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = String.Empty;
        }
    }
}
