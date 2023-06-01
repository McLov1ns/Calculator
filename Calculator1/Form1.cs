using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator1
{
    public partial class Калькулятор : Form
    {
        float inputA;
        float inputB;
        int choice;
        public Калькулятор()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            inputA = float.Parse(textBox1.Text);
            textBox1.Clear();
            choice = 1;
            label1.Text = inputA.ToString() + "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            inputA = float.Parse(textBox1.Text);
            textBox1.Clear();
            choice = 2;
            label1.Text = inputA.ToString() + "-";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            inputA = float.Parse(textBox1.Text);
            textBox1.Clear();
            choice = 3;
            label1.Text = inputA.ToString() + "*";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //inputA = float.Parse(textBox1.Text);
            textBox1.Clear();
            choice = 4;
            label1.Text = inputA.ToString() + "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Calculate();
            label1.Text = "";
        }

        private void Calculate()
        {
            switch (choice)
            {
                case 1:
                    inputB = inputA + float.Parse(textBox1.Text);
                    textBox1.Text = inputB.ToString();
                    break;
                case 2:
                    inputB = inputA - float.Parse(textBox1.Text);
                    textBox1.Text = inputB.ToString();
                    break;
                case 3:
                    inputB = inputA * float.Parse(textBox1.Text);
                    textBox1.Text = inputB.ToString();
                    break;
                case 4:
                    inputB = inputA / float.Parse(textBox1.Text);
                    textBox1.Text = inputB.ToString();
                    break;
                default:
                    break;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }
    }
}