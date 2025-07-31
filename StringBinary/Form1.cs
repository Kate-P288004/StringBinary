using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringBinary
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        public string StringToBinary(string data)
        {
            // string to binary data c#
            StringBuilder sb = new StringBuilder();
            foreach (char c in data.ToCharArray())
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            return sb.ToString();
        }

        private void btnConvert_Click_Click(object sender, EventArgs e)
        {
            // c# string to binary
            txtOutput.Text = StringToBinary(txtInput.Text);
        }
    }

}
