using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controles
{
    public partial class NumericTextBox : TextBox
    {
        private string validChars = ".0123456789";

        public NumericTextBox()
        {
            this.Text = "0.00";
            this.Leave += NumericTextBox_Leave;
            this.Click += NumericTextBox_Click;
            this.GotFocus += NumericTextBox_GotFocus;
            this.KeyPress += NumericTextBox_KeyPress;
            this.TextChanged += NumericTextBox_TextChanged;
        }

        public void Clear()
        {
            Text = "0.00";
        }

        void NumericTextBox_Leave(object sender, EventArgs e)
        {
            if (Text == "")
            {
                Text = "0.00";
            }
        }

        void NumericTextBox_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        void NumericTextBox_GotFocus(object sender, EventArgs e)
        {
            SelectAll();
        }

        public bool HaveDot
        {
            get;
            set;
        }

        void NumericTextBox_TextChanged(object sender, EventArgs e)
        {
            HaveDot = Text.Contains('.');
        }

        void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar))
            {
                if (!validChars.Contains(e.KeyChar) || (e.KeyChar == '.' && HaveDot))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
