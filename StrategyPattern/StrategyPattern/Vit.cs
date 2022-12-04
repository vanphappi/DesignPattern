using StrategyPattern.Behaviour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal abstract class Vit
    {
        IHanhViBay _hanhViBay;
        IHanhViKeu _hanhViKeu;

        public abstract void HienThi();
        public void Boi()
        {
            Console.WriteLine("Boi Tren Mat Nuoc");
        }
        
        public void CachBay()
        {
            _hanhViBay.Bay();
        }

        public void CachKeu()
        {
            _hanhViKeu.Keu();
        }
        public void SetHanhViBay(IHanhViBay _hanhViBay)
        {
            this._hanhViBay = _hanhViBay;
        }
        public void SetHanhViKeu(IHanhViKeu _hanhViKeu)
        {
            this._hanhViKeu = _hanhViKeu;
        }
    }
}
