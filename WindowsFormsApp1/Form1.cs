﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Dog> dogs;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            dogs = new List<Dog>();
            string[] lines = File.ReadAllLines("../../../BookingInfo.txt");
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                dogs.Add(new Dog(data[0], int.Parse(data[1])));



            }
            dataGridView1.Columns.Add("First Name", "First Name");
            dataGridView1.Columns.Add("Last Name", "Last Name");
            dataGridView1.Columns.Add("Phone Number", "Phone Number");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Seats", "Seats");
            //dataGridView1.Columns.Add("age", "age");
            //dataGridView1.Columns.Add("names", "names");
            //dataGridView1.Columns.Add("age", "age");
            foreach (string dogs in lines )
                {
                    int rowIdx = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIdx].Cells["First Name"].Value = booking;
                    dataGridView1.Rows[rowIdx].Cells["Last Name"].Value = dogs;
                    dataGridView1.Rows[rowIdx].Cells["Phone Number"].Value = dogs;
                    dataGridView1.Rows[rowIdx].Cells["Email"].Value = dogs;
                    dataGridView1.Rows[rowIdx].Cells["Seats"].Value = dogs;




                
            }
        }
    }
}
