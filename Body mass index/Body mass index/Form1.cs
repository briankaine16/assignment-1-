using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Body_mass_index
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtResult.Text = "";

            radKg.Checked = false;
            radLb.Checked = false;

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(txtWeight.Text);
            double height = Convert.ToDouble(txtHeight.Text);
            double result = 0.0;
            string result2 = "";

            if (radKg.Checked)
            {
                result = weight / (height * height);
            }
            else
                if (radLb.Checked)
            {
                weight = weight / 2.205;
                result = weight / (height * height);
            }
            if (result < 18.5)
            {
                result2 = "You are underweight";
            }
            else
                if (result < 25)
            {
                result2 = "You have a normal weight";
            }
            else
                if (result < 30)
            {
                result2 = "You are overweight";
            }
            else
                if (result >= 30)
            {
                result2 = "You are Obese";
            }
            txtResult.Text = "Your body mass index is :" + result.ToString("#.#") + "\r\n" + result2;
        }
    }
}
