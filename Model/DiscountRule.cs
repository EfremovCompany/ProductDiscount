using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDiscount.Model
{
    class StatusProduct
    {
        public Status status;
        public int condition;

        public StatusProduct(Status status, int condition)
        {
            this.condition = condition;
            this.status = status;
        }
    }

    public enum Status { and, or, global };

    class DiscountRule
    {
        //массив продуктов
        private List<Product> items;
        private int discountPersent;
        private StatusProduct statusProduct;

        public int DiscountPersent
        {
            get
            {
                return discountPersent;
            }

            set
            {
                discountPersent = value;
            }
        }

        public DiscountRule(int discountPersent, List<Product> items, StatusProduct status)
        {
            this.statusProduct = status;
            this.discountPersent = discountPersent;
            this.items = items;
        }

        public double discount()
        {
            double result = 0;
            switch (statusProduct.status)
            {
                case Status.and:
                    foreach (Product product in items)
                    {
                        if (!product.hasDiscount())
                        {
                            result += product.discount(discountPersent, false);
                        }
                    } 
                    break;
                case Status.or:
                    break;
                case Status.global:
                    if (items.Count >= statusProduct.condition)
                    {
                        foreach (Product product in items)
                        {
                            product.discount(discountPersent, true);
                        }
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
