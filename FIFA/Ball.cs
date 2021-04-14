using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFA
{
    public interface Ball
    {
        //public List<IObserver> observers;
        public void Attach(IObserver observer);
   
        public void Detach(IObserver observer);
     
        public void Notify();
        
    }
}
