using System;
using System.Threading.Tasks;

namespace Order
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int o_id = rnd.Next();
            Task.Run(() => OrderCheck.NewOrder().Order_ID = o_id);
            Task.Run(() => OrderCheck.NewOrder().CreateOrder());
            Task.Run(() => OrderCheck.NewOrder().ShowOrder());
            Task.WaitAll();
            Task.Run(() => OrderCheck.NewOrder().Order_ID = o_id);
            Task.Run(() => OrderCheck.NewOrder().CreateOrder());
            Task.Run(() => OrderCheck.NewOrder().ShowOrder());
            Task.WaitAll();
        }
    }
}