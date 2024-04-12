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
