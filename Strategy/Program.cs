using System;
using FIFA2;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Team Barcelona = new Team();
            Barcelona.SetStrategy(new AttackStrategy());
            Barcelona.PlayGame();
            Barcelona.SetStrategy(new DefenceStrategy());
            Barcelona.PlayGame();
        }
    }
}
