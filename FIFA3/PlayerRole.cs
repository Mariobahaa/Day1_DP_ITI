using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA3
{
    public abstract class PlayerRole : Player
    {
        Player player;
        public virtual void PassBall()
        {
            if (player != null)
                player.PassBall();
        }

        public void AssignPlayer(Player p)
        {
            player = p;
        }

    }
}
