﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Test
{
    public static class Hashkod
    {
        public static string Hash(string input)
        {
            byte[] hash = Encoding.ASCII.GetBytes(input);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] hashenc = md5.ComputeHash(hash);
            string output = "";
            foreach (var b in hashenc)
            {
                output += b.ToString("x2");
            }
            return output;
        }

    }
}
