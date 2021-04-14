using System;
using FIFA;
namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Player P1 = new Player();
            Player P2 = new Player();
            Referee referee = new Referee();
            Football football = new Football();
            football.Attach(P1);
            football.Attach(P2);
            football.Attach(referee);
            football.SetPosition(new BallPosition(1, 1, 1));

        }
    }
}
