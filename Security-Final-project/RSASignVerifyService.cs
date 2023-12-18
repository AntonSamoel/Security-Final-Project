using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace Security_Final_project
{
    public class RSASignVerifyService
    {
        private static RSACryptoServiceProvider csp = new(2048);
        public RSAParameters _privateKey;
        public RSAParameters _publicKey;

        public RSASignVerifyService()
        {
            _privateKey = csp.ExportParameters(true);
            _publicKey = csp.ExportParameters(false);
        }
        public string GetKey(bool ok)
        {
            var sw = new StringWriter();
            var xmlSerializer = new XmlSerializer(typeof(RSAParameters));
            if (ok)
                xmlSerializer.Serialize(sw, _privateKey);
            else xmlSerializer.Serialize(sw, _publicKey);
            return sw.ToString();
        }
        public string SignData(string data)
        {
            using var rsa = new RSACryptoServiceProvider();
           
            rsa.ImportParameters(_privateKey);
            var dataToSign = Encoding.UTF8.GetBytes(data);
            var signature = rsa.SignData(dataToSign, HashAlgorithmName.SHA512, RSASignaturePadding.Pkcs1);
            return Convert.ToBase64String(signature);
        }
        public bool VerifySignature(string data, string signature)
        {
            using var rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(_publicKey);
            var dataToVerify = Encoding.UTF8.GetBytes(data);
            bool x = false;
			try
            {
               var signatureData = Convert.FromBase64String(signature);
               x = rsa.VerifyData(dataToVerify, signatureData, HashAlgorithmName.SHA512, RSASignaturePadding.Pkcs1);

            }
            catch(Exception ex)
            {

            }
            return x;
        }

    }

}
