using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherGUI.CipherManager
{
    interface IManager
    {
        string Execute(string msg);

        string Unexecute(string msg);
    }
}
