﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack <Sweepstakes> sweepstakesStack = new Stack <Sweepstakes>();

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {

            sweepstakesStack.Push(sweepstakes);

        }
        public Sweepstakes GetSweepstakes()
        {
            return sweepstakesStack.Pop();

        }
    }
}
