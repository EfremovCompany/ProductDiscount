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
            Random random = new Random();
            for (char letter = 'A'; letter <= 'M'; letter++)
            {
                //TODO:  to const
                this.productList.Add(new Product(letter.ToString(), random.Next(1, 100)));
            }
        }

        private void initRules()
        {
            //Статическое добавление правил
            this.rules = new List<DiscountRule>();
            //TODO: fill data
            this.rules.Add(new DiscountRule(10, prepareProductArray(new string[] { "A", "B" })));
            this.rules.Add(new DiscountRule(5, prepareProductArray(new string[] { "D", "E" })));
            this.rules.Add(new DiscountRule(5, prepareProductArray(new string[] { "E", "F", "G" })));
        } 

        private List<Product> prepareProductArray(string[] nameList)
        {
            List<Product> productList = new List<Product>();
            foreach (string s in nameList)
            {
                productList.Add(findByName(s));
            }
            return productList;
        }

        private Product findByName(string name)
        {
            return productList.FirstOrDefault(b => b.getName() == name);
        }
    }
}
