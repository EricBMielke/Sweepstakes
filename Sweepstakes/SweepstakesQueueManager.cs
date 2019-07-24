using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager 
    {

        Queue<Sweepstakes> sweepstakesStack = new Queue<Sweepstakes>();

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesStack.Enqueue(sweepstakes);


        }
        public Sweepstakes GetSweepstakes()
        {
            return sweepstakesStack.Dequeue();
        }

    }
}
