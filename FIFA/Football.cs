using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA
{
    public class Football : Ball
    {
        private BallPosition position;

        public Football()
        {
            position = new BallPosition();
        }

        public BallPosition GetPosition() { return position; }
        public void SetPosition(BallPosition pos)
        {
            if(pos!= null)
            {
                this.position = pos;
                Console.WriteLine("Changed ball position");
                Notify();
            }
        }
    }
}
