using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA3
{
    public class Midfielder: PlayerRole
    {
        public override void PassBall()
        {
            base.PassBall();
            Dribble();
        }
        public void Dribble()
        {

            Console.WriteLine("Midfielder Dribbles!");
        }
    }
}
