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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int[] arr1 = new int[10];
        int[] arr2 = new int[17];
        
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox4.Visible = true;
           


            comboBox1.Enabled = false;
            comboBox2.Enabled = true;
            comboBox4.Enabled = true;

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox4.Text = "";
            for (int i = 0; i < arr1.Length; i++)
            {

                
                arr1[i] = rnd.Next(1, 10);
                comboBox2.Text += String.Format("{0,5}", arr1[i]);
            }
            for (int i = 0; i < arr2.Length; i++)
            {

                comboBox1.Text += String.Format("{0,5}", i);
                arr2[i] = rnd.Next(1, 10);
                comboBox4.Text += String.Format("{0,5}", arr2[i]);
            }
            Array.Sort(arr1);
            Array.Sort(arr2);
            Array.Reverse(arr2);
            button2.Visible = true;

            comboBox2.Enabled = false;
            comboBox1.Enabled = false;
            comboBox4.Enabled = false;
        }
        static bool Unical(int[] arr, int ind)
        {
            
            for (int i = 0; i < ind; i++)
            {
                if (arr[i] == arr[ind]) return false;
            }
            return true;
        }
        static bool Exists(int[] arr, int a)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == a) return true;
            }
            return false;
        }
        public void Buble(int[] arr,int r)
        {
            for (int g = 0; g < r; g++)
            {
                for (int i = 0; i < r - 1; i++)
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
        private void button2_Click(object sender, EventArgs e)
        {

            comboBox3.Visible = true;
            comboBox3.Enabled = true;
            comboBox3.Text = "";
            int c = 0;
            int[] arr = new int[arr1.Length +arr2.Length];
            int m = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (Unical(arr1, i))
                {
                    arr[m] = arr1[i];
                    m++;
                }
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                if (!Exists(arr, arr2[i]))
                {
                    arr[m + count] = arr2[i];
                    c++;
                }
            }
            Buble(arr,m+c);
            for (int i = 0; i < m+c; i++)
            {
                comboBox3.Text += String.Format("{0,5}", arrf[i]);
            }
            
            comboBox3.Enabled = false;

        }
    }
}
