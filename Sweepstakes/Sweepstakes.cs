using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        Dictionary<string, Contestant> contestantDict = new Dictionary<string, Contestant>();
        Contestant contestant = new Contestant();

        public string contestantAge;
        public int contestantCount = 0;
        public string Name;

        public void RunGame()
        {
            string userName = GetName(Name);
            string userAge = Sweepstake(userName);
            contestant.GetInfo();
            RegisterContestant(contestant);

        }
        public string GetName(string Name)
        {
            Console.WriteLine("Hello, what is your name?");
            Name = Console.ReadLine();
            return Name;
        }
        public string Sweepstake(string Name)
        {
            Console.WriteLine("Good morning" + Name + "You must be 18 to enter the sweepstakes. Please acknowledge this by typing 'yes'.");
            contestantAge  = Console.ReadLine();
            contestantCount++;
            return contestantAge;
        }

        public void RegisterContestant(Contestant contestant)
        {
            AddUserToData(contestant, contestantCount);
        }
        public void AddUserToData(Contestant contestant, int contestantCount)
        {
            contestantDict.Add(contestantCount.ToString(), contestant);
            contestantDict.Add(contestant.FirstName, contestant);
            contestantDict.Add(contestant.LastName, contestant);
            contestantDict.Add(contestant.EmailAddress, contestant);
            contestantDict.Add(contestant.RegistrationNumber, contestant);

        }
        public char PickWinner()
        {
            Random rnd = new Random();
            int sweepstakesWinnerNumber = rnd.Next(1, contestantCount);
            char sweepStakesWinner = contestant.FirstName[sweepstakesWinnerNumber];
            return sweepStakesWinner;
        }
        //public void AlertWinner(int sweepstakesWinner)
        //{

        //    for (int i = 0; i < contestantCount; i++)
        //    {
        //        contestantCount.ToString();
        //        if(contestantCount = contestantDict.)
        //        {
        //            Console.WriteLine("contest")
        //        }
        //        Console.WriteLine("Value of i: {0}", i);
        //    }
        //}
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("First Name: " + contestant.FirstName);
            Console.WriteLine("Last Name: " + contestant.LastName);
            Console.WriteLine("Email Address: " + contestant.EmailAddress);
            Console.WriteLine("Registration Number: " + contestant.RegistrationNumber);
        }

    }
    public interface UserInformation
    {
        void GetFirstName();
        void GetLastName();
        void GetEmail();
        void GetRegistrationNumber();
    }
    public interface ISweepstakesManager
    {
        void InsertSweepstakes(Sweepstakes sweepstakes);
        Sweepstakes GetSweepstakes();
    }
}
