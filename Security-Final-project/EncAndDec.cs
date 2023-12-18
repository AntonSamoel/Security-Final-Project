using System.Windows.Forms;

namespace Security_Final_project
{
    public partial class EncAndDec : Form
    {
        public EncAndDec()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
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
						inputDataRichTextBox.Text = reader.ReadToEnd();
					}
				}
					
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputDataRichTextBox.Text))
            {
				string encryptedData = EncryptAndDecrypt.EncryptData(inputDataRichTextBox.Text);
				resultButton.Text = "Encryption Result";
				ShowResultRichTextBox.Text = encryptedData;
			}
            
           
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            string decryptedData = EncryptAndDecrypt.DecryptData(ShowResultRichTextBox.Text);
            resultButton.Text = "Decryption Result";
            ShowResultRichTextBox.Text = decryptedData;
        }

        private void saveToFile_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text files (*.txt) | *.txt";
                saveFileDialog.ShowDialog();
                File.AppendAllText(saveFileDialog.FileName, ShowResultRichTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void clearResultButton_Click(object sender, EventArgs e)
        {
            ShowResultRichTextBox.Text = string.Empty;
        }

        private void clearDataButton_Click(object sender, EventArgs e)
        {
            inputDataRichTextBox.Text = string.Empty;

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
						EncryptAndDecrypt.key = reader.ReadToEnd();
					}
				}

				
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
