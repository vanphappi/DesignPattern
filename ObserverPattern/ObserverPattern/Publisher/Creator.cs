using ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Publisher
{
    internal class Creator : EventManager
    {
        private string _content;

        public Creator()
        {
            this._evenType = EvenType.Creator;
        }
        public void SetContent(string _content)
        {
            this._content = _content;
            ContentChange();
        }

        public string GetContent()
        {
            return this._content;
        }
        public void ContentChange()
        {
            Notify(null);
        }
    }
}
