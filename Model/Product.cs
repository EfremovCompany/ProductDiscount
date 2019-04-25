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

        public Product(string name, double cost)
        {
            this.name = name;
            this.cost = cost;
        }

        public string getName()
        {
            return this.name;
        }
    }
}
