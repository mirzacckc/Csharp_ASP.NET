using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace ders_16032022
{
    public class Sifreleme
    {
        public static string HashSHA1(string plaintext)
        {
            using (var sha1provider = new SHA1CryptoServiceProvider())
            {
                var hash = sha1provider.ComputeHash(Encoding.UTF8.GetBytes(plaintext));
                return BitConverter.ToString(hash).Replace("-", "");
            }
        }
    }
}