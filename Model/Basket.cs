using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDiscount.Model
{
    class Basket
    {
        private static Basket instance;
        private List<Product> productList;
        private List<DiscountRule> rules;

        //Init

        private Basket()
        {
            //TODO: init products and rules
        }

        public static Basket getInstance()
        {
            if (instance == null)
                instance = new Basket();
            return instance;
        }

        private void initProductList()
        {
            this.productList = new List<Product>();
            //TODO: to const values
            for (int i = 0; i < 11; i++)
            {
                //TODO: добавить рандом
                this.productList.Add(new Product("A", 10));
            }
        }

        private void initRules()
        {
            //Статическое добавление правил
            this.rules = new List<DiscountRule>();
            //TODO: fill data
            this.rules.Add(new DiscountRule(10, null));
        } 
    }
}
