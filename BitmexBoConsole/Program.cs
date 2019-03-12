using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitMEX;

namespace BitmexBoConsole
{
    class Program
    {
        private static string bitmexKey = "G1Z4URdqAB7I7KsZavUuHtIT";
        private static string bitmexSecret = "QqN6064v-AJ-iuwiX-cPy1D9ySQVElyy63jc5_G5Z0ASCve4";

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run(args);
        }

        private void Run(string[] args)
        {
            BitMEXApi bitmex = new BitMEXApi(bitmexKey, bitmexSecret);
            // var orderBook = bitmex.GetOrderBook("XBTUSD", 3);
            //var orders = bitmex.GetOrders();

            var leverage = bitmex.Leverage("XBTUSD", 100);
            //bitmex.PostOrders();
           
            // var orders = bitmex.DeleteOrders();
            //Console.WriteLine(orders);

            Console.ReadKey();
        }
    }
}
