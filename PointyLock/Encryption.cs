using System.Security.Cryptography;
using System.Text;

namespace PointyLock
{
    public class Encrypt
    {
        public static byte[] HashPassword(string password)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(bytes);
            }
        }

        public static void EncryptFile(string path, byte[] key)
        {
            if (key.Length != 16 && key.Length != 24 && key.Length != 32)
                throw new ArgumentException("Invalid key size. Key must be 16, 24, or 32 bytes.");

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.GenerateIV();

                using (FileStream outputStream = new FileStream(path + ".ple", FileMode.Create, FileAccess.Write))
                {
                    outputStream.Write(aes.IV, 0, aes.IV.Length);

                    using (CryptoStream cryptoStream = new CryptoStream(outputStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    using (FileStream inputStream = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        inputStream.CopyTo(cryptoStream);
                    }
                }

            }
        }

        public static void DecryptFile(string path, byte[] key)
        {
            if (!path.EndsWith(".ple"))
                throw new ArgumentException("File was not encrypted with PointyLock.");

            // Validate key length
            if (key.Length != 16 && key.Length != 24 && key.Length != 32)
                throw new ArgumentException("Invalid key size. Key must be 16, 24, or 32 bytes.");

            using (FileStream inputStream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (Aes aes = Aes.Create())
                {
                    byte[] iv = new byte[16];
                    inputStream.Read(iv, 0, iv.Length);
                    aes.Key = key;
                    aes.IV = iv;

                    // Decrypt the file
                    using (CryptoStream cryptoStream = new CryptoStream(inputStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    using (FileStream outputStream = new FileStream(path.Remove(path.Length - 4), FileMode.Create, FileAccess.Write))
                    {
                        cryptoStream.CopyTo(outputStream);
                    }
                }
            }
        }
    }
}