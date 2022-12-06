using ObserverPattern.ConcreteSubscribers;
using ObserverPattern.Publisher;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _editor = new Editor();
            var _creator = new Creator();

            var _logging = new LoggingListener(_editor);
            var _email = new EmailAlertsListener(_creator);

            //_editor.Unsubcribe(EvenType.Editor,_logging);

            _editor.SetContent("Desgin Pattern Observer");


        }
    }
}