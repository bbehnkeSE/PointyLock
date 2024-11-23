using System.Security.Cryptography;
using System.Text;

namespace PointyLock
{
    public class Encrypt
    {
        public static byte[] HashPassword(string password)
        {
            int keysize = 64;
            byte[] salt = RandomNumberGenerator.GetBytes(keysize);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(password),
                salt,
                100_000,
                HashAlgorithmName.SHA512,
                keysize);

            return hash;
        }

        public static void EncryptPath(string path)
        {
            
        }
    }
}