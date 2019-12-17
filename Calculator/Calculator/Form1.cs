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
    public partial class label : Form
    {
        Double ans = 0;
        String operation = "";
        bool isOperation = false;

        public label()
        {
            InitializeComponent();
        }

        private void click_button(object sender, EventArgs e)
        {
            if ((text_box.Text == "0") || (isOperation))
                text_box.Clear();

            isOperation = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!text_box.Text.Contains("."))
                    text_box.Text=text_box.Text + button.Text;
            }else
            text_box.Text = text_box.Text + button.Text;
        }
        private void click_operator(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (ans != 0)
            {
                eq.PerformClick();
                operation = button.Text;
                label_operator.Text = ans + " " + operation;
                isOperation = true;

            }
            else
            {
                operation = button.Text;
                ans = Double.Parse(text_box.Text);
                label_operator.Text = ans + " " + operation;
                isOperation = true;
            }
        }
        private void clearEntry_operator(object sender, EventArgs e)
        {
            text_box.Text = "0";
        }

        private void clear_operator(object sender, EventArgs e)
        {
            text_box.Text = "0";
            ans = 0;

        }
        private void equal_operator(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    text_box.Text = (ans + Double.Parse(text_box.Text)).ToString();
                    break;
                case "-":
                    text_box.Text = (ans - Double.Parse(text_box.Text)).ToString();
                    break;
                case "*":
                    text_box.Text = (ans * Double.Parse(text_box.Text)).ToString();
                    break;
                case "/":
                    text_box.Text = (ans / Double.Parse(text_box.Text)).ToString();
                    break;
                default:
                    break;

            }
            ans = Double.Parse(text_box.Text);
            label_operator.Text = "";
        }
    }
}











