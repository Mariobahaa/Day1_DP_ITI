using System;
using FIFA3;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {

          

            Console.WriteLine("test ************");

            FieldPlayer Messi = new FieldPlayer();
            Forward d1 = new Forward();
            Midfielder d2 = new Midfielder();

            // Link decorators
            d1.AssignPlayer(Messi);
            d2.AssignPlayer(d1);

            d2.PassBall();
            //Messi.ShootGoal(); // should shoot, pass 
            //Messi.PassBall(); // should pass 
            //Console.WriteLine("Iniesta ************");
            //Midfielder Iniesta = new Midfielder();
            //Iniesta.AssignPlayer(Messi);
            ////Iniesta.Dribble(); //should shoot, pass and dribble 
            //Iniesta.PassBall(); //should pass 
        }
    }
}
