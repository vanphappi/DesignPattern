using ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Subscribers
{
    internal abstract class EventListeners
    {
        protected EventManager _event;
        public abstract void Update(object agr);
    }
}
