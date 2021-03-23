using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double val = 0;
        string operation = "";
        bool press = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (press) txtDisplay.Clear();
            press = false;
            Button b = (Button)sender;
            txtDisplay.Text = txtDisplay.Text + b.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
        }

        private void btn_Operator(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            val = Double.Parse(txtDisplay.Text);
            press = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (val + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (val - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "X":
                    txtDisplay.Text = (val * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (val / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                default: break;
            }
        }
    }
}
