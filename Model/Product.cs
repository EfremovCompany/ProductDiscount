using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDiscount.Model
{
    class Product
    {
        private string name;
        private double cost;
        private bool isDiscount = false;

        public Product(string name, double cost)
        {
            this.name = name;
            this.cost = cost;
        }

        public string getName()
        {
            return this.name;
        }

        public double getCost()
        {
            return this.cost;
        }

        public bool hasDiscount()
        {
            return this.isDiscount;
        }

        public double discount(int percent, bool isGlobal)
        {
            if (!isGlobal || !isDiscount)
            {
                Console.Write("Product {0}, old {1} ", name, cost);
                this.cost = this.cost - (this.cost / 100) * percent;
                Console.WriteLine("new {0}", cost);
                this.isDiscount = !isGlobal;
            }
            return this.cost;
        }
    }
}
