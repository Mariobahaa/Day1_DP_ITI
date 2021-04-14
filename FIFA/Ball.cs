using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA
{
    public class Ball
    {
        List<IObserver> observers = new List<IObserver>();
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
    }
}
