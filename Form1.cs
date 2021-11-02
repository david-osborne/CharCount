using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharCount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numUpDown.Value = 30;
        }

        public int charLen;

        private void TbInput_TextChanged(object sender, EventArgs e)
        {
            charLen = tbInput.Text.Length;
            MaxLengthCheck(charLen);
        }

        private void MaxLengthCheck (int charLen)
        {
            tbCharLen.Text = charLen.ToString();
            if (charLen > numUpDown.Value)
            {
                tbCharLen.BackColor = Color.LightPink;
            }
            else
                tbCharLen.BackColor = Color.LightGreen;
        }

        private void NumUpDown_ValueChanged(object sender, EventArgs e)
        {
            MaxLengthCheck(charLen);
        }
    }
}
