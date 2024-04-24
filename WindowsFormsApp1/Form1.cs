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
            bookingInfo = new List<BookingInfo>();

            BookingInfo.ReadFromFile(@"../../../BookingInfo.txt", bookingInfo);
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
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("First Name", "First Name");
            dataGridView1.Columns.Add("Last Name", "Last Name");
            dataGridView1.Columns.Add("Phone Number", "Phone Number");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Seats", "Seats");
            //dataGridView1.Columns.Add("age", "age");
            //dataGridView1.Columns.Add("names", "names");
            //dataGridView1.Columns.Add("age", "age");
            foreach (BookingInfo booking in bookingInfo)
            {
                int rowIdx = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIdx].Cells["First Name"].Value = booking.FirstName;
                dataGridView1.Rows[rowIdx].Cells["Last Name"].Value = booking.LastName;
                dataGridView1.Rows[rowIdx].Cells["Phone Number"].Value = booking.PhoneNum;
                dataGridView1.Rows[rowIdx].Cells["Email"].Value = booking.Email;
                dataGridView1.Rows[rowIdx].Cells["Seats"].Value = booking.Seats;
            }
        }
        public void button1_Click(object sender, EventArgs e)
        {
            int id = bookingInfo.Count + 1;
            string name = textFirstName.Text;
            string lastName = textLastName.Text;
            string phoneNum = textPhNum.Text;
            string email = textEmail.Text;
            int seats = Convert.ToInt32(textSeats.Text);
            bookingInfo.Add( new BookingInfo(id, name, lastName, phoneNum, email, seats));
            Save(id, name, lastName, phoneNum, email, seats);
            
        }
        static void Save(int id, string name, string lastName, string phoneNum, string email, int seats)
        {
            StreamWriter sw = new StreamWriter(@"../../../BookingInfo.txt", true);
            sw.Write("\n" + id + "," + name + "," + lastName + "," + phoneNum + "," + email + "," + seats);
            sw.Close();

        }
    }
}
