

namespace Security_Final_project
{
    public class ConfidentialityAndAuthentication
    {
        private RSASignVerifyService rsaVerifyService;

        public ConfidentialityAndAuthentication()
        {
            rsaVerifyService = new RSASignVerifyService();
        }

        public string SignAndEncrypt(string data)
        {
            string output = data;

            output += $"\nSIGNATURE\n";

            output += rsaVerifyService.SignData(data);

            output = EncryptAndDecrypt.EncryptData(output);

            return output;
        }
        public bool IsDecryptedAndVerified(string data)
        {
            string output = data;

            output = EncryptAndDecrypt.DecryptData(output);

            string[] split = output.Split("\nSIGNATURE\n");
            bool x = false;
            try { 
                x = rsaVerifyService.VerifySignature(split[0], split[1]);
			}
            catch(Exception e)
            {
                x = false;
            }

            return x;
        }
        public string[] DecryptAndVerify(string data)
        {
            string output = data;

            output = EncryptAndDecrypt.DecryptData(output);

            string[] split = output.Split("\nSIGNATURE\n");

            return split;
        }
    }
}
