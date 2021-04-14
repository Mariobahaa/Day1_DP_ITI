using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA3
{
    public class Forward: PlayerRole
    {
        public override void PassBall()
        {
            base.PassBall();
            ShootGoal();
        }
        public void ShootGoal()
        {
            //base.PassBall();
            Console.WriteLine("Forwared Shoots Gooooooal !");
        }
    }
}
