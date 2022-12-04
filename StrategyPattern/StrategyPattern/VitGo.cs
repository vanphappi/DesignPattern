using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class VitGo : Vit
    {
        public override void HienThi()
        {
            Console.WriteLine("Vit Go");
        }
    }
}
