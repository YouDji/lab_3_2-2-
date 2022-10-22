using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double a ,x,v;
            string c_one = textBox1.Text;
            int c = Convert.ToInt32(c_one);
            int N = 20,i;
            int[] Mas = new int[20]; 
            for(i = 0; i < N; i++)
            {
                Mas[i] = rand.Next(10);
                Console.Write(Mas[i] + " ");
            }
            Console.WriteLine();
            for( v = 0; v< N; v++)
            {
                if(c == v)
                {
                    if (c % 2 == 1)
                    {
                        a = Math.PI* Math.Pow(i,2);
                        textBox2.Text = a.ToString();

                    }
                    if (c%2==0)
                    {
                    x= 2* Math.PI* i;
                    textBox2.Text = x.ToString(); }
                }
            }

        }
    }
}
