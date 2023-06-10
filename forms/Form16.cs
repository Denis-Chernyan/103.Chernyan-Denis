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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
            textBox1.Visible = false;
        }
        int[] arr = new int[1000];
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1 .Visible = true;
            int b = 0, c = 0, b1 = 0, currentLineIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 7);
                
            }
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1] )
                {
                    if (c == 0)
                    {
                        c++;
                        currentLineIndex = i - 1;
                    }
                        
                    c++;
                    if (c > b && i == arr.Length-1)
                    {
                        b = c;
                        b = currentLineIndex;
                        

                    }
                }
                else if (c > b)
                {
                    b = c;
                    b1 = currentLineIndex;
                    c = 0;

                }
                else
                {
                    c = 0;

                }

            }
            textBox1.Text = String.Format("Длина самой длинной цепочки: {0}\r\n Начальный индекс цепочки : {1} \r\n Значение элемента: {2}", b, b1, arr[b1]);
        }
    }
}
