﻿using System;
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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        int[] arr = new int[20];
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            comboBox2.Visible = true;



            comboBox1.Enabled = false;
            comboBox2.Enabled = true;

            comboBox1.Text = "";
            comboBox2.Text = "";

            for (int i = 0; i < arr.Length; i++)
            {

                comboBox1.Text += String.Format("{0,5}", i);
                arr[i] = rnd.Next(1, 10);
                comboBox2.Text += String.Format("{0,5}", arr[i]);
            }

            button2.Visible = true;

            comboBox2.Enabled = false;
            comboBox1.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {




        }
        static int MinMax(int[] arr, bool max, int nachalo, int last)
        {
            int t = nachalo;
            for (int i = nachalo; i <= last; i++)
            {
                if ((!max && arr[t] > arr[i]) || (max && arr[t] < arr[i])) t = i;
            }
            return t;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            comboBox3.Visible = true;
            comboBox3.Enabled = true;
            comboBox3.Text = "";
            
            int last = arr.Length - 1;
            int k = 0;
            for (int i = 0; i < (arr.Length) / 2 - 1; i++)
            {

                int t = arr[MinMax(arr, false, k, last];
                arr[MinMax(arr, false, start, end)] = arr[i];
                arr[i] = t;
                
                k++;



                int t1 = arr[MinMax(arr, false, k, last)];
                arr[MinMax(arr, false, k, last)] = arr[last];
                arr[last] = t1;

                last --;


            }
            for (int i = 0; i < arr.Length; i++)
            {
                comboBox3.Text += String.Format("{0,5}", arr[i]);
            }



            comboBox3.Enabled = false;
        }        
    }
}
