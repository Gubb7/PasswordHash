﻿using System.Security.Cryptography;
using System.Text;

namespace PasswordHash
{
    public static class Hashing
    {
        public static string ToSHA256(string password)
        {
            using var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

            var stringBytes = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                stringBytes.Append(bytes[i].ToString("x2"));
            }

            return stringBytes.ToString();
        }
    }
}