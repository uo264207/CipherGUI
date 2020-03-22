using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CipherGUI
{
    class CipherRSA
    {
        private static CipherRSA INSTANCE= new CipherRSA();
        private static RSAParameters public_key;
        private static RSAParameters private_key;
        public CipherRSA getInstance()
        {
            return INSTANCE;
        }
        private CipherRSA()
        {
            RSAKeyCreator.createKeys();
            public_key = RSAKeyCreator.getPublicKey();
            private_key = RSAKeyCreator.getPrivateKey();

        }
       public static byte[] encrypt(string message)
        {
            byte[] encrypted = Encrypt(Encoding.UTF8.GetBytes(message));
            return encrypted;
        }

        public static string decrypt(byte[] message)
        {
            byte[] decrypted = Decrypt(message);
            return Encoding.UTF8.GetString(decrypted);
        }

        private static byte[] Encrypt(byte[] input)
        {
            byte[] encrypted;

            using(var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(public_key);
                encrypted = rsa.Encrypt(input, true);
            }
            return encrypted;
        }

        private static byte[] Decrypt(byte[] input)
        {
            byte[] decrypted;

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(private_key);
                decrypted = rsa.Decrypt(input, true);
            }
            return decrypted;
        }
    }
}
