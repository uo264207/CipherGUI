using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherGUI.CipherManager
{
    class RSAManager:IManager
    {
        public string Execute(string msg)
        {
            string encrypted_text = "";
            byte[] encrypted = CipherRSA.encrypt(msg);

            encrypted.ToList<byte>().ForEach((num) => encrypted_text += num);

            return encrypted_text;
        }

        

        public string Unexecute(string msg)
        {
            byte[] decrypted = Encoding.UTF8.GetBytes(msg);

            string decryptedText = CipherRSA.decrypt(decrypted);

            return decryptedText;
        }

        public override string ToString()
        {
            return "RSA";
        }
    }
}
