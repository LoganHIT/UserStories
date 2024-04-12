using System;
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

        

        public static List<BookingInfo> bookingInfo = new List<BookingInfo>();


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

       

        private void button2_Click_1(object sender, EventArgs e)
        {

            booking = new List<BookingInfo>();
            string[] lines = File.ReadAllLines("../../../BookingInfo.txt");
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                booking.Add(new BookingInfo(data[0], int.Parse(data[1])));



            }
            dataGridView1.Columns.Add("First Name", "First Name");
            dataGridView1.Columns.Add("Last Name", "Last Name");
            dataGridView1.Columns.Add("Phone Number", "Phone Number");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Seats", "Seats");
            //dataGridView1.Columns.Add("age", "age");
            //dataGridView1.Columns.Add("names", "names");
            //dataGridView1.Columns.Add("age", "age");
            foreach (string dogs in lines)
            {
                int rowIdx = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIdx].Cells["First Name"].Value = booking;
                dataGridView1.Rows[rowIdx].Cells["Last Name"].Value = booking;
                dataGridView1.Rows[rowIdx].Cells["Phone Number"].Value = booking;
                dataGridView1.Rows[rowIdx].Cells["Email"].Value = booking;
                dataGridView1.Rows[rowIdx].Cells["Seats"].Value = booking;





            }

        public void button1_Click(object sender, EventArgs e)
        {
            string name = textFirstName.Text;
            string lastName = textLastName.Text;
            string phoneNum = textPhNum.Text;
            string email = textEmail.Text;
            int seats = Convert.ToInt32(textSeats.Text);
            bookingInfo.Add( new BookingInfo(name, lastName, phoneNum, email, seats));
            Save(name, lastName, phoneNum, email, seats);
            
        }
        static void Save(string name, string lastName, string phoneNum, string email, int seats)
        {
            StreamWriter sw = new StreamWriter(@"../../../BookingInfo.txt");
            sw.WriteLine(name);
            sw.WriteLine(lastName);
            sw.WriteLine(phoneNum);
            sw.WriteLine(email);
            sw.WriteLine(seats);
            sw.Close();

        }
    }
}
