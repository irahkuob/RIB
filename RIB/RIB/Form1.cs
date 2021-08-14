using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RIB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        string cle;
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {if (cpt_txt.Text == "")
            {
                cle_txt.Text = "";
                rip_txt.Text = "";
                all_txt.Text = "";
            }
            else
            {
                //    cle =cle_cpt(con_ten(cpt_txt.Text));
                cle_txt.Text = cle_cpt(con_ten(cpt_txt.Text));
                rip_txt.Text = rib_cpt(con_rib(cpt_txt.Text).Substring(3,15));
                all_txt.Text = con_rib(cpt_txt.Text) + rib_cpt(con_rib(cpt_txt.Text).Substring(3, 15));
            }
           // MessageBox.Show(cle_cpt(con_ten(cpt_txt.Text)));
        }
        public string cle_cpt(String cpt)
        {///return string value!!!
            string cle = "";
            char[] tt = cpt.ToCharArray();
            
                int s = 0; int j = 4;
                for (int i = tt.Length-1; i >= 0; i--)
                {
                    s += (int.Parse(tt[i].ToString())) * j;
                    j++;
                }
            if (s > 10) { cle = s.ToString().Substring(s.ToString().Length - 2); } else cle = "0"+s.ToString();
            return cle;
        }
        public string con_ten(String s)
        {
             int y; string h; int l = s.Length;
            if (l <= 10) { y = 10 - l; } else y = 0;
            for (int j = 0; j < y; j++)
            {
                s="0"+s;
            }
            return s;

        }
        public string con_rib(String s)
        {
            string rib = "00799999";
            int y; string h; int l = s.Length;
            if (l <= 10) { y = 10 - l; } else y = 0;
            for (int j = 0; j < y; j++)
            {
                rib += "0";
                       }
            return rib+s;

        }
        public string rib_cpt(string cpt)
        {
            string rib = "";
            
                Int64 ribb = (97 - (((long.Parse(cpt)) * 100) % 97));
                if (ribb < 10)
                { rib = "0" + ribb; }
                else
                {
                    if (ribb == 0)
                    { rib = "97"; }
                    else rib = ribb.ToString();
                }
            return rib;
        }

        private void Copy_Click(object sender, EventArgs e)
        {if (all_txt.Text!="") { 
            Clipboard.Clear();
            Clipboard.SetText(all_txt.Text);}
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox2.Text = "";
                textBox1.Text = "";
                            }
            else
            {  
                textBox2.Text = rib_cpt(textBox4.Text);
                textBox1.Text = textBox4.Text+ rib_cpt(textBox4.Text); ;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                Clipboard.Clear();
                Clipboard.SetText(textBox4.Text);
            }
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
