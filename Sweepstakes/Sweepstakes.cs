using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Dictionary<string, string> contestant = new Dictionary<string, string>();
        public string contestantAge;
        public int contestantCount = 0;
        public string[] allCustomerData;
        public string Sweepstake(string Name)
        {
            Console.WriteLine("Good morning" + Name + "You must be 18 to enter the sweepstakes. Please acknowledge this by typing 'yes'.");
            contestantAge  = Console.ReadLine();
            contestant.Add("Age", contestantAge);
            contestantCount++;
            return contestantAge;
        }

        public void RegisterContestant(Contestant contestant)
        {

        }
        public void AddUserToData(Contestant contestant, int contestantCount)
        {
            var allCustomerData = new[] { 
            new { Num = contestantCount, Details = new[] { 
                new {KeyChar = '1', StringValue = contestant.FirstName} , 
                new {KeyChar = '2', StringValue = contestant.LastName} ,
                new {KeyChar = '3', StringValue = contestant.EmailAddress} ,
                new {KeyChar = '4', StringValue = contestant.RegistrationNumber} }
            } };
        }
        public string PickWinner()
        {
            return "foo";
        }
        public void PrintContestantInfo(Contestant contestant)
        {

        }

    }
    public interface UserInformation
    {
        void GetFirstName();
        void GetLastName();
        void GetEmail();
        void GetRegistrationNumber();
    }
    interface ISweepstakesManager
    {
        void InsertSweepstakes(Sweepstakes sweepstakes);
        Sweepstakes GetSweepstakes();
    }
}
