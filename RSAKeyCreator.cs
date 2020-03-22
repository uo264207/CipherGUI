using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CipherGUI
{
    class RSAKeyCreator
    {
        private static RSAParameters _public_key;
        public static RSAParameters public_key { get { return _public_key; } }

        private static RSAParameters _private_key;
        public static RSAParameters private_key { get { return _private_key; } }

        public static void createKeys()
        {
            using(var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                _public_key = rsa.ExportParameters(false);
                _private_key = rsa.ExportParameters(true);
            }
        }
        public static RSAParameters getPublicKey()
        {
            return public_key; 
        }

        public static RSAParameters getPrivateKey()
        {
            return private_key;
        }
    }
}
