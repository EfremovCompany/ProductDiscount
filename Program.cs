using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            var busket = Model.Basket.getInstance();
            Console.WriteLine(busket.getCost().ToString());
            Console.ReadKey();
        }
    }
}
