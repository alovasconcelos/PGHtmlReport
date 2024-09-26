using System.Security.Cryptography;
using System.Text;

namespace PGHtmlReport.Util;
public static class CriptoHelper
{
    // Método para criptografar
    public static string Cripto(string plainText, string key)
    {
        using (Aes aesAlg = Aes.Create())
        {
            using (var keyDerivation = new Rfc2898DeriveBytes(key, Encoding.UTF8.GetBytes("SaltValue"), 1000))
            {
                aesAlg.Key = keyDerivation.GetBytes(32);
                aesAlg.IV = keyDerivation.GetBytes(16);

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        return Convert.ToBase64String(msEncrypt.ToArray());
                    }
                }
            }
        }
    }

    // Método para descriptografar
    public static string Decripto(string cipherText, string key)
    {
        using (Aes aesAlg = Aes.Create())
        {
            using (var keyDerivation = new Rfc2898DeriveBytes(key, Encoding.UTF8.GetBytes("SaltValue"), 1000))
            {
                aesAlg.Key = keyDerivation.GetBytes(32);
                aesAlg.IV = keyDerivation.GetBytes(16);

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
