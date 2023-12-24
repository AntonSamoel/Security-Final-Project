using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Security_Final_project
{
	public class EncryptAndDecrypt
	{
		public static string key = "1234567891234567";
		public static string EncryptData(string inputData)
		{
			try
			{
				using (Aes aesAlg = Aes.Create())
				{
					aesAlg.Key = Encoding.UTF8.GetBytes(key);
					aesAlg.IV = new byte[16]; // Initialization Vector

					using (ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV))
					{
						using (MemoryStream msOutput = new MemoryStream())
						{
							using (CryptoStream cs = new CryptoStream(msOutput, encryptor, CryptoStreamMode.Write))
							{
								byte[] dataBytes = Encoding.UTF8.GetBytes(inputData);
								cs.Write(dataBytes, 0, dataBytes.Length);
								cs.FlushFinalBlock();
							}

							return Convert.ToBase64String(msOutput.ToArray());
						}
					}
				}
			}
			catch (Exception ex)
			{
				return $"Encryption failed: {ex.Message}\nKey Size must be 16 Characters";
			}
		}

		public static string DecryptData(string encryptedData)
		{
			try
			{
				using (Aes aesAlg = Aes.Create())
				{
					aesAlg.Key = Encoding.UTF8.GetBytes(key);
					aesAlg.IV = new byte[16]; // Initialization Vector

					using (ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV))
					{
						using (MemoryStream msInput = new MemoryStream(Convert.FromBase64String(encryptedData)))
						{
							using (StreamReader sr = new StreamReader(new CryptoStream(msInput, decryptor, CryptoStreamMode.Read)))
							{
								return sr.ReadToEnd();
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				return $"Decryption failed: {ex.Message}";
			}
		}
	}
}
