using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA
{
    public class BallPosition
    {
        public int Xpos { get; set; }
        public int Ypos { get; set; }

        public int Zpos { get; set; }

        public BallPosition()
        {
            Xpos = Ypos = Zpos = 0;
        }

        public BallPosition(int x, int y, int z)
        {
            Xpos = x;
            Ypos = y;
            Zpos = z;
        }
    }
}
