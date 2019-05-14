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
        private double cost = 0;
        private bool isBlockGlogal = false;

        //Init

        private Basket()
        {
            initProductList();
            initRules();
        }

        public static Basket getInstance()
        {
            if (instance == null)
                instance = new Basket();
            return instance;
        }

        public double getCost()
        {
            return cost;
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
            createRule(10, prepareProductArray(new string[] { "A", "B" }), new StatusProduct(Status.and, 0));
            createRule(5, prepareProductArray(new string[] { "D", "E" }), new StatusProduct(Status.and, 0));
            createRule(5, prepareProductArray(new string[] { "E", "F", "G" }), new StatusProduct(Status.and, 0));

            //createRule(3, productList, new StatusProduct(Status.global, 3));

            foreach(Product product in productList)
            {
                if (!product.hasDiscount())
                {
                    Console.WriteLine("Product {0}, cost {1} ", product.getName(), product.getCost());
                    cost += product.getCost();
                }
            }
        } 

        private void createRule(int percent, List<Product> productList, StatusProduct status)
        {
            var rule = new DiscountRule(percent, productList, status);
            this.cost += rule.discount();
            this.rules.Add(rule);
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
