using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        private string firstName;
        private string lastName;
        private int registrationNumber;
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
        public int RegistrationNumber
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
        public void GetContestant(Contestant contestant)
        {
            Console.WriteLine("What is your first name?");
            contestant.FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            contestant.LastName = Console.ReadLine();
            Console.WriteLine("What is your email");
            contestant.EmailAddress = Console.ReadLine();
            Console.WriteLine("What is your phone number");
            contestant.RegistrationNumber = Convert.ToInt32(Console.ReadLine());
        }



    }
}
