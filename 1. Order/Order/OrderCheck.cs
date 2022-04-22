using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class OrderCheck
    {
        private static OrderCheck _Order = null;
        private static object _Lock = new object();
        public int Order_ID;
        
        private const int N = 30;
        public struct Order_List
        {
            public string name;
            public int quantity;
        }
        Order_List[] OL = new Order_List[N];
        public int pc = 0; // product count
        private OrderCheck()
        {
            Console.WriteLine("Order Information");
        }
        public void CreateOrder()
        {
            int option = 1;
            while(option == 1)
            {
                Console.WriteLine("Product[" + pc + "] info : ");
                Console.WriteLine("Name : ");
                OL[pc].name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Quantity : ");
                OL[pc].quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Do you want to add another product ? (0/1)");
                option = Convert.ToInt32(Console.ReadLine());
                pc++;
            }
        }
        public void ShowOrder()
        {
            Console.WriteLine("That's Your Order with ID : " + Order_ID);
            for (int i = 0; i < pc; i++)
            {
                Console.WriteLine(OL[i].name + "...................." + OL[i].quantity);
            }
            Console.WriteLine("------------------------------");
        }
        public static OrderCheck NewOrder()
        {
            if (_Order == null)
            {
                lock(_Lock)
                {
                    if (_Order == null)
                    {
                        Thread.Sleep(500);
                        _Order = new OrderCheck();
                    }
                }
            }
            return _Order;
        }
    }
}
