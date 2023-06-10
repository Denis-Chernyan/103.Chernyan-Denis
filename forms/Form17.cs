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

namespace MarkovForms
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int p = Convert.ToInt32(textBox1.Text);
                if (p < 1) throw new Exception("Число должно быть натуральным");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int[] arr = new int[textBox1.Text.Length];
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                arr[i] = textBox1.Text[i] -'0';
            }
            Buble(arr, arr.Length);
            if (arr[0] == 0)
            {
                int f = 0;
                do
                {
                    f++;
                }
                while (arr[f] == 0);
                arr[0] = arr[f];
                arr[f] = 0;
            }
            textBox2.Text = "";
            for (int i = 0; i < arr.Length; i++)
            {
                textBox2.Text += arr[i];
            }
        }
        public void Buble(int[] arr, int t)
        {
            for (int k = 0; k < t; k++)
            {
                for (int i = 0; i < t - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int t = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = t;

                    }
                }
            }
        }
    }
}
