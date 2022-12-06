using ObserverPattern.Publisher;
using ObserverPattern.Subject;
using ObserverPattern.Subscribers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.ConcreteSubscribers
{
    internal class LoggingListener : EventListeners
    {
        public LoggingListener(EventManager _event)
        {
            this._event = _event;
            _event.Subscribe(this);
        }
        public override void Update(object arg)
        {
            if(_event is Editor editor)
            {
                Console.WriteLine($"Gui Thong Bao Den LoggingListener Co Noi Dung Moi : " +
                    $"Content = {editor.GetContent()}");
            }
        }
    }
}
