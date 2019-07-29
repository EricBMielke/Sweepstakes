using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class ManagerFactory
    {
        public ISweepstakesManager GetSweepstakes()
        {
            Console.WriteLine("Choose your sweepstake manager style: stack or queue");
            string choiceOfManagement = Console.ReadLine();
            if (choiceOfManagement == "stack")
            {
                return new SweepstakesStackManager();
            }
            else if (choiceOfManagement == "queue")
            {
                return new SweepstakesQueueManager();
            }
            else
            {
                Console.WriteLine("Invalid Choice. Please use either 'stack' or queue'");
                return GetSweepstakes();
            }
        }

    }
}
