using StrategyPattern.Behaviour;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vit v1 = new VitTroi();
            v1.SetHanhViBay(new BayCao());
            v1.SetHanhViKeu(new KeuNho());
            v1.HienThi();
            v1.Boi();
            v1.CachBay();
            v1.CachKeu();
            Console.WriteLine("__________________________");
            Vit v2 = new VitCaoSu();
            v2.SetHanhViBay(new KhongBay());
            v2.SetHanhViKeu(new KhongKeu());
            v2.HienThi();
            v2.Boi();
            v2.CachBay();
            v2.CachKeu();
        }
    }
}