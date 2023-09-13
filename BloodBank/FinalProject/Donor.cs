using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Donor
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private string _phoneNumber;
        private BloodType  _userBlood;
        private string _bloodInfo;
        private DateTime _donationDate;

        private string _email;
        private string _password;

        public Donor(string firstName, string lastName, string address, string phoneNumber, BloodType userBlood, string bloodInfo, DateTime donationDate, string email, string password)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _phoneNumber = phoneNumber;

            _userBlood = userBlood;

            //Do we need _bloodInfo?
            _bloodInfo = bloodInfo;
            _donationDate = donationDate;

            _email = email;
            _password = password;
        }

        public string GetFirstName()
        {
            return _firstName;
        }

        public string GetLastName()
        {
            return _lastName;
        }

        public string GetAddress()
        {
            return _address;
        }

        public string GetPhoneNumber()
        {
            return _phoneNumber;
        }

        public BloodType GetBloodType()
        {
            return _userBlood;
        }

        public string GetInfo()
        {
            return _bloodInfo;
        }

        public DateTime GetDonationDate()
        {
            return _donationDate;
        }
        public string GetEmail()
        {
            return _email;
        }

        public string GetPassword()
        {
            return _password;
        }
    }
}
