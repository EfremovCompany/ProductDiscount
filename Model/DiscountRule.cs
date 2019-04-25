using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDiscount.Model
{
    class DiscountRule
    {
        //массив продуктов, если передается null - то скидка применяется ко всем товарам
        private Product[] items;
        private int discountPersent;
        //TODO: возможно не понадобится
        private int priority;

        public DiscountRule(int discountPersent, Product[] items)
        {
            this.discountPersent = discountPersent;
            this.items = items;
        }
    }
}
