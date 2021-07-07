using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t4_008wf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) % Convert.ToInt32(textBox2.Text));

           else if (radioButton2.Checked == true)
                textBox3.Text = Convert.ToString(Math.Pow(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));

           else if (radioButton3.Checked == true)
                textBox3.Text = textBox1.Text + textBox2.Text;

           else if (radioButton4.Checked == true)
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text));
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
