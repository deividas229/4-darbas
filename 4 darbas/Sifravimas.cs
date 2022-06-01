using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace _4_darbas
{
    class Sifravimas
    {
        public string PasswordCiphering(string file, string password) 
        {
            Encoding encoding = Encoding.GetEncoding("437");
            byte[] bytesToBeEncrypted = encoding.GetBytes(file);
            byte[] passwordBytes = encoding.GetBytes(password);
            passwordBytes = MD5.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = Encryption(bytesToBeEncrypted, passwordBytes);
            string slpt = encoding.GetString(bytesEncrypted);

            return slpt;
        }

        public string PasswordDecrypt(string file, string password) 
        {
            Encoding encoding = Encoding.GetEncoding("437");
            byte[] bytesToBeEncrypted = encoding.GetBytes(file);
            byte[] passwordBytes = encoding.GetBytes(password);
            passwordBytes = MD5.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = Decryption(bytesToBeEncrypted, passwordBytes);
            string slpt = encoding.GetString(bytesEncrypted);

            return slpt;
        }

        public void EncryptCiphering(string file, string password) 
        {
            byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            passwordBytes = MD5.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = Encryption(bytesToBeEncrypted, passwordBytes);
            string fileEncrypted = file;

            File.WriteAllBytes(fileEncrypted, bytesEncrypted);
        }

        public void DecryptCiphering(string fileEncrypted, string password)
        {
            byte[] bytesToBeDecrypted = File.ReadAllBytes(fileEncrypted);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            passwordBytes = MD5.Create().ComputeHash(passwordBytes);
            try
            {
                byte[] bytesDecrypted = Decryption(bytesToBeDecrypted, passwordBytes);

                string file = fileEncrypted;
                File.WriteAllBytes(file, bytesDecrypted);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        public static byte[] Decryption(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;

            
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }
            return decryptedBytes;
        }

        public static byte[] Encryption(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;

            
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }
            return encryptedBytes;
        }
    }
}
