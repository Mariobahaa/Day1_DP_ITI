using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA3
{
    public class Defender: PlayerRole
    {
        public override void PassBall()
        {
            base.PassBall();
            Defend();
        }
        public void Defend()
        {
            
            Console.WriteLine("Defender defends <>");
        }
    }
}
