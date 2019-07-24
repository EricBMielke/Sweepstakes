using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        ISweepstakesManager sweepstakesManager;
        public void InsertSweepstakes(ISweepstakesManager sweepstakesManager)
        {
            this.sweepstakesManager = sweepstakesManager; 
        }
        public Sweepstakes GetSweepstakes()
        {
            return sweepstakesManager.GetSweepstakes();
        }
    }
}
