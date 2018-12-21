using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.NUnitIntroduction.Models
{
    public class OrderInfo
    {
        public int Price { get; set; }

        public int Id { get; set; }

        public override bool Equals(object obj)
        {
            var order = obj as OrderInfo;
            if (order != null)
            {
                return order.Id == this.Id && order.Price == this.Price;
            }
            return false;
        }
    }
}
