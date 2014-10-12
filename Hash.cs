using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace HashCalculator
{
    class Hash
    {
        public string getMd5Hash(string FileName)
        {
            FileStream stream = File.OpenRead(FileName);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", String.Empty).ToLower();
        }

        public string getSha1Hash(string FileName)
        {
            FileStream stream = File.OpenRead(FileName);
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            return BitConverter.ToString(sha1.ComputeHash(stream)).Replace("-", String.Empty).ToLower();
        }
    }
}
