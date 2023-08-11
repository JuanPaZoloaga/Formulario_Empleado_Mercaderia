using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace parcial.Security
{
    public class HashDirectory
    {
        public static string ToSHA256(string s)
        {
            using var sha256 = SHA256.Create();
            var sb = new StringBuilder();

            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));

            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }

}

