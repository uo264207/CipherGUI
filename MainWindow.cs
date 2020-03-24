using CipherGUI.CipherManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherGUI
{
    public partial class MainWindow : Form
    {
        IManager cipher_mode;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cipher_mode = (IManager) combox_encrypt.SelectedItem;
           
        }


        private void Button1_Click(object sender, EventArgs e)
        {

            if (!(cipher_mode is null)){
               output_text.Text=cipher_mode.Execute(input_text.Text);
            }
        }

       
    }
}
