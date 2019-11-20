using System;
using System.Collections.Generic;
using System.Text;
using CryptoHelper;

namespace ProtectionData
{
    public class UtilityTools
    {
        // Method for hashing the password 
        public string HashPassword(string password)
        {
            return Crypto.HashPassword(password);
        }

        // Method to verify the password hash against the given password 
        public bool VerifyPassword(string hash, string password)
        {
            return Crypto.VerifyHashedPassword(hash, password);
        }
    }
}
