using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant : UserInformation
    {
        private string firstName;
        private string lastName;
        private string registrationNumber;
        private string emailAddress;

        Contestant contestant = new Contestant();
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }
            set
            {
                registrationNumber = value;
            }
        }
        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }
            set
            {
                emailAddress = value;
            }
        }
        public void GetFirstName()
        {
            Console.WriteLine("What is your first name?");
            contestant.FirstName = Console.ReadLine();
        }
        public void GetLastName()
        {
            Console.WriteLine("What is your last name?");
            contestant.LastName = Console.ReadLine();
        }
        public void GetEmail()
        {
            Console.WriteLine("What is your email?");
            contestant.EmailAddress = Console.ReadLine();
        }
        public void GetRegistrationNumber()
        {
            Random rnd = new Random();
            contestant.RegistrationNumber = rnd.Next(1000000).ToString();
            Console.WriteLine("Your registration number is " + contestant.RegistrationNumber);

        }

        public void GetInfo()
        {
            GetFirstName();
            GetLastName();
            GetEmail();
            GetRegistrationNumber();
        }



    }
}
