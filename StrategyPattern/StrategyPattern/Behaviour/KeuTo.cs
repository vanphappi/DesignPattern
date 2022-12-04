using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviour
{
    internal class KeuTo : IHanhViKeu
    {
        public void Keu()
        {
            Console.WriteLine("Keu To");
        }
    }
}
