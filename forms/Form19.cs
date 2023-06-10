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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int e;
            try
            {
                e = Convert.ToInt32(textBox1.Text);
                
                if (e <1) throw new Exception("Число должно быть натуральным");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int[,] arr = new int[e,e];

            
            textBox3.Text = "";
            for (int i = 0; i < e; i++)
            {
                arr[i, i] = i+1;
                arr[i, e - i - 1] = e - i;
            }
            for (int i = 0; i < e; i++)
            {
                for (int j = 0; j < e; j++)
                {
                    textBox3.Text += arr[i, j].ToString() + " ";
                }
                textBox3.Text += "\r\n";
            }
        }
    }
}
