using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviour
{
    internal class KhongBay : IHanhViBay
    {
        public void Bay()
        {
            Console.WriteLine("Khong Bay");
        }
    }
}
