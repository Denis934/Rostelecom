using System;
using System.Security.Cryptography;
using System.Text;

namespace RostelecomApplication
{
    public class Generetion //  программа
    {
        public static string GetKod(int length) // генерация кода
        {
            Random random = new Random();

            string numericСode = null;

            for (int i = 0; i < length; i++)
            {
                numericСode += random.Next(0, 10);
            }
            return numericСode;
        }
        public static string GetSalt(int length) // генерация соли
        {
            RNGCryptoServiceProvider p = new RNGCryptoServiceProvider();

            var salt = new byte[length];

            p.GetBytes(salt);

            return Convert.ToBase64String(salt);
        }
        public static string GetSHA1(string numericСode, string salt) // хеширование код+соль
        {
            SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider();

            sh.ComputeHash(Encoding.UTF8.GetBytes(numericСode + salt));

            byte[] re = sh.Hash;

            StringBuilder sb = new StringBuilder();

            foreach (byte b in re)
            {
                sb.Append(b.ToString("X2")); // для представления в 16 ричном виде
            }

            return sb.ToString();
        }
    }
}
