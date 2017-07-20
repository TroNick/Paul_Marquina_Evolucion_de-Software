using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        string Color_to_Hex(Color c)
        {
            return ColorTranslator.ToOle(c).ToString("X");
        }
        //===============================
        Color Hex_to_Color(string hx)
        {
            int x = int.Parse(hx, System.Globalization.NumberStyles.HexNumber);
            Color c = ColorTranslator.FromOle(x);
            return c;
        }
        int f = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] colors = Enum.GetNames(typeof(KnownColor));
            foreach (string s in colors)
            {
                listBox1.Items.Add(s);
            }
            timer1.Enabled = true;
            timer1.Start();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromName(listBox1.SelectedItem.ToString());
            pictureBox1.BackColor= Color.FromName(listBox1.SelectedItem.ToString());
            string str = listBox1.SelectedItem.ToString();
            Color c = Color.FromName(str);
            textBox1.Text = Color_to_Hex(c);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
