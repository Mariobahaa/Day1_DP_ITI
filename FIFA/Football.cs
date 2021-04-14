using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA
{
    public class Football : Ball
    {
        private List<IObserver> observers = new List<IObserver>();

        private BallPosition position;

        public Football()
        {
            position = new BallPosition();
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }
        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            if (observers != null)
            {
                foreach (IObserver observer in observers)
                {
                    observer.Update(this);
                }
            }
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
