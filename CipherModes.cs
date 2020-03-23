using CipherGUI.CipherManager;
using System.Collections.Generic;

namespace CipherGUI
{
    internal class CipherModes
    {
       
        public static IManager[] getAll()
        {
            List<IManager> listManagers = new List<IManager>();

            listManagers.Add(new RSAManager());

            return listManagers.ToArray();
        }
    }
}