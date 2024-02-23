using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Average_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextPoints1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TextPoints2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TextPoints3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TextPoints4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void ButtonComputer_Click(object sender, EventArgs e)
        {
            float sum = 0, medium, value;
            
            foreach (Control control in this.Controls)
            {

                if (control is TextBox)
                {
                    string text = ((TextBox)control).Text;
                    if (float.TryParse(text, out value))
                    {
                        sum += value;
                    }
                }

                medium = sum / 4;
                this.Controls["MediumBox"].Text = medium.ToString();
            }
            
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            TextPoints1.Text = "";
            TextPoints2.Text = "";
            TextPoints3.Text = "";
            TextPoints4.Text = "";

        }
    }
}
