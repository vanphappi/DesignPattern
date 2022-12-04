using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class VitTroi : Vit
    {
        public override void HienThi()
        {
            Console.WriteLine("Vit Troi");
        }
    }
}
