using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        float a, b;
        int operators;
        bool sign = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text != "0") && !(TextBox1.Text == "0,")) 
            {
                TextBox1.Text = TextBox1.Text + 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 2;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 3; 
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 4;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 5;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 6;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 7;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 8;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 9;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.IndexOf(',') == -1){
                TextBox1.Text += ",";
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != ""){
                a = float.Parse(TextBox1.Text);
                TextBox1.Clear();
                label1.Text = "+";
                operators = 1;
                sign = true;
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                a = float.Parse(TextBox1.Text);
                TextBox1.Clear();
                label1.Text = "-";
                operators = 2;
                sign = true;
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                a = float.Parse(TextBox1.Text);
                TextBox1.Clear();
                label1.Text = "*";
                operators = 3;
                sign = true;
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                a = float.Parse(TextBox1.Text);
                TextBox1.Clear();
                label1.Text = "/";
                operators = 4;
                sign = true;
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                calculate();
                label1.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button17_Click(object sender, EventArgs e)
        {
            if (sign == true)
            {
                TextBox1.Text = "-" + TextBox1.Text;
                sign = false;
            }
            else if (sign == false)
            {
                TextBox1.Text = TextBox1.Text.Replace("-", "");
                sign = true;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button19_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            label1.Text = "";
            a = 0;
            b = 0;
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            int lenght = TextBox1.Text.Length - 1;
            string text = TextBox1.Text;
            TextBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                TextBox1.Text = TextBox1.Text + text[i];
            }
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 box1 = new AboutBox1();
            box1.Show();
        }

        private void calculate()
        {
            switch (operators)
            {
                case 1:
                    b = a + float.Parse(TextBox1.Text);
                    TextBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(TextBox1.Text);
                    TextBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(TextBox1.Text);
                    TextBox1.Text = b.ToString();
                    break;
                case 4:

                    if (float.Parse(TextBox1.Text) == 0)
                    { TextBox1.Text = "Делить на 0 нельзя!"; }
                    else
                    {
                        b = a / float.Parse(TextBox1.Text);
                        TextBox1.Text = b.ToString();
                    }
                    break;
                default:
                    break;
            }
        }
    }
   
}
