using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security_Final_project
{
    public partial class RSASignVerifycs : Form
    {
        RSASignVerifyService service = new();
        string sig = "";
        // string data = "";
        public RSASignVerifycs()
        {
            InitializeComponent();
        }

        private void Choosebtn_Click(object sender, EventArgs e)
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

        private void Signbtn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length == 0)
            {
                // richTextBox1.Text = "No Data To Show";
                MessageBox.Show("Input Data is empty");
            }
            else
            {
                sig = service.SignData(richTextBox1.Text);
                //data = richTextBox1.Text;

                richTextBox2.Text = richTextBox1.Text + "\nSIGNETURE\n" + sig;
            }
        }

        private void ClearDatabtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = String.Empty;
        }

        private void ClearResultbtn_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = String.Empty;
        }

        private void Verifybtn_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text.Length == 0)
            {
                //richTextBox2.Text = "Result is Empty";
                MessageBox.Show("Result is empty");
            }
            else
            {
                string[] d = richTextBox2.Text.Split("\nSIGNETURE\n");
                if (d.Length != 2)
                {
                    richTextBox2.Text = "There is No Signeture !!!\n"
                        + "Please Split Data From Signeture By \"\\nSIGNETURE\\n\"";
                }
                else if (service.VerifySignature(d[0], d[1]))
                {
                    richTextBox2.Text = "Verified Successfully";
                }
                else
                {
                    richTextBox2.Text = "Verification Fails !!!!";
                }
                //richTextBox2.Text = d[0] + d[1];
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
