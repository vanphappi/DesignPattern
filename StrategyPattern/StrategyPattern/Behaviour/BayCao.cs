using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviour
{
    internal class BayCao : IHanhViBay
    {
        public void Bay()
        {
            Console.WriteLine("Bay Cao");
        }
    }
}
