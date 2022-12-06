using ObserverPattern.Subscribers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Subject
{
    internal class EventManager
    {
        private readonly List<EventListeners> _listeners = new List<EventListeners>();
        protected EvenType _evenType;
        public void Subscribe(EventListeners _listener)
        {
            Console.WriteLine($"{_listener.GetType()} Dang ki Theo Doi Su Kien {_evenType.ToString()}");
            _listeners.Add(_listener);
        }

        public void Unsubcribe(EventListeners _listener)
        {
            Console.WriteLine($"{_listener.ToString()} Huy Theo Doi Su Kien {_evenType.ToString()}");
            _listeners.Remove(_listener);
        }

        public void Notify(object agr)
        {
            Console.WriteLine($"{_evenType.ToString()} Thong Bao Co Cap Nhat Moi !!");
            foreach(EventListeners i in _listeners)
            {
                i.Update(agr);
            }

        }
    }
}
