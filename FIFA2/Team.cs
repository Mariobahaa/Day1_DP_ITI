using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA2
{
    public class Team
    {
        Strategy strategy;

        public void SetStrategy(Strategy newStrategy)
        {
            this.strategy = newStrategy;
        }

        public void PlayGame()
        {
            this.strategy.Play();
        }
    }
}
