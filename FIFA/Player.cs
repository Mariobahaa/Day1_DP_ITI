using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA
{
    public class Player: IObserver
    {
        private BallPosition ballPosition;

        public void Update(Ball football) //or use ball interface (observer)
        {
          
            if( football is Football)
            {
                ballPosition = ((Football) football).GetPosition();
                Console.WriteLine("Updated Player's ball position");

            }


        }
    }
}
