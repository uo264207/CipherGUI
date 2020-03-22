using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherGUI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            byte[] original = CipherRSA.encrypt("PatataMorena");

            string originalText ="";
            original.ToList<byte>().ForEach((num) => originalText += num);
           
            string decrypted = CipherRSA.decrypt(original);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
            
        }
    }
}
