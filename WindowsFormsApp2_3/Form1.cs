using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(textBox1.Text);
                int B_original = Convert.ToInt32(textBox2.Text);
                int B1 = B_original; int B2 = B_original;
                textBox3.Text = ""; textBox4.Text = ""; textBox5.Text = "";
                if (A > B_original) { MessageBox.Show("B должно быть больше A"); }
                else
                {
                    while (A <= B1)
                    {
                        textBox3.Text += Math.Pow(B1, 3).ToString();
                        textBox3.Text += Environment.NewLine;
                        B1--;
                    }

                    do
                    {
                        textBox4.Text += Math.Pow(B2, 3).ToString();
                        textBox4.Text += Environment.NewLine;
                        B2--;
                    } while (A <= B2);

                    for (int i = B_original; A <= i; i--)
                    {
                        textBox5.Text += Math.Pow(i, 3).ToString();
                        textBox5.Text += Environment.NewLine;

                    }
                }
            }
            catch
            {
                MessageBox.Show("Некорректный ввод данных");
            }
        }
    }
}
