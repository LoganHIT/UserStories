using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class BookingInfo
    {
        private int id;
        private string firstName;
        private string lastName;
        private string phoneNum;
        private string email;
        private int seats;
        //card num
        //card name
        //card date
        //card 3 digit
        //night1
        //night2
        //night3

        public BookingInfo(int id, string firstName, string lastName, string phoneNum, string email, int seats)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNum = phoneNum;
            this.email = email;
            this.seats = seats;
        }

        public int ID { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Email { get => email; set => email = value; }
        public int Seats { get => seats; set => seats = value; }


        public static void ReadFromFile(string filePath, List<BookingInfo> booking)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                string[] bookingDetails = line.Split(',');

                int id = int.Parse(bookingDetails[0]); //id
                string firstName = bookingDetails[1]; //first name
                string lastName = bookingDetails[2]; //last name
                string phoneNum = bookingDetails[3]; //course number
                string email = bookingDetails[4];
                int seats = int.Parse(bookingDetails[5]); //seats amount
                booking.Add(new BookingInfo(id, firstName, lastName, phoneNum, email, seats));
            }
        }

    }
}
