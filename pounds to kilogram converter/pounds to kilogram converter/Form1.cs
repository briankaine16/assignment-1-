using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pounds_to_kilogram_converter
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

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double Pound = (double)numericUpDown1.Value;
            double Answer = Pound * 0.453592;
            label3.Text = Answer.ToString() + "KGs";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double KG = (double)numericUpDown2.Value;
            double Answer2 = KG * 2.20462;
            label3.Text = Answer2.ToString() + "pounds";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            label3.Text = "Answer";
        }
    }
}
