using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkovForms
{
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int p, s;
            try
            {
                p = Convert.ToInt32(textBox1.Text);
                s = Convert.ToInt32(textBox2.Text);
                if (m <3||n<3) throw new Exception("Оба числа должны быть больше двух");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int[,] arr = new int[p, s];
            
            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    arr[i, j] = rnd.Next(0, 10);
                }
            }
            textBox3.Text = "";
            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    textBox3.Text += (j == 0 || j == s - 1 || i == 0 || i == p - 1)?arr[i, j].ToString()+" ":" " + "  ";
                }
                textBox3.Text += "\r\n";
            }
        }
    }
}
