using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class BookingInfo
    {
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

        public BookingInfo(string firstName, string lastName, string phoneNum, string email, int seats)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNum = phoneNum;
            this.email = email;
            this.seats = seats;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Email { get => email; set => email = value; }
        public int Seats { get => seats; set => seats = value; }




    }
}
