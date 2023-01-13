using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHW3
{
    internal class Journal
    {
        private string _name;
        private int _year;
        private string _discription;
        private long _phoneNumber;
        private string _email;

        public Journal(string name)
        {
            _name = name;
        }

        public void ChangeName(string name)
        {
            _name = name;
        }
        public void SetYear(int year)
        {
            _year = year;
        }
        public void SetDiscripion(string discription)
        {
            _discription = discription;
        }
        public void SetPhoneNumber(long phoneNumber)
        {
            _phoneNumber = phoneNumber;
        }

        public void SetEmail(string email)
        {
            _email = email;
        }

        public void ShowJournalInfo()
        {
            Console.WriteLine($"The information about Journal {_name}");
            Console.WriteLine($"The Journal {_name} was founded in {_year}, if you want " +
                $"to contact us, please use this phone number {_phoneNumber} or e-mail: {_email}");
            Console.WriteLine($"Discription: {_discription}");
        }

    }
}
