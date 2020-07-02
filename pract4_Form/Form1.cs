using System;
using System.Windows.Forms;

namespace pract4_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && CheckValueType(textBox1.Text)) {
                try
                {
                    int n = Convert.ToInt32(textBox1.Text);
                    if (n <= 0) throw new Exception();
                    int a = f(n);
                    if (Math.Pow(2, a - 1) <= n && n <= Math.Pow(2, a)) textBox2.Text = "The a is " + a;
                    else textBox2.Text = "The a is " + a + ". But " + n + " is not between " + Math.Pow(2, a - 1) + " and " + Math.Pow(2, a);
                }
                catch
                {
                    textBox2.Text = "The value cant be negative";
                }
            }
                
        }
        private bool CheckValueType(String str)
        {
            
                char[] chArr = str.ToCharArray();
                for (int i = 0; i < chArr.Length; i++)
                {
                try
                {
                    if (!char.IsDigit(chArr[i]) || chArr[i]=='-')
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    textBox2.Text = "The value is invalid";
                    return false;
                }
                }
                return true;
            }
        private int f(int n)
        {
            if (n == 1) return 1;
            else return (f(n / 2) + 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "" && CheckValueType(textBox3.Text))
            {
                try
                {
                    int k = Convert.ToInt32(textBox3.Text);
                    if (k <= 0) throw new Exception();
                    textBox4.Text = "";
                    rec(k);
                }
                catch
                {
                    textBox2.Text = "The value cant be negative";
                }
            }
        }
        private void rec(int k)
        {
            for (int i = 1; i <= k; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    textBox4.AppendText(i + " ");
                }
                textBox4.AppendText(Environment.NewLine);
            }
        }
    }

    }

