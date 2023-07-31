using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using System;
using finalProject.Data.Common;

namespace finalProject.Data.Models
{
    public class SaleItem : BaseEntity
    {
        // to generate unique ID.
        private static int count = 0;

        public SaleItem(Product product, int quantity)
        {
            Quantity = quantity;
            //Sets Product property of the SalesItem to the provided product.
            Product = product;
            // Sets the ID to a unique value using count and then increment the count.
            ID = count;
            count++;

        }

        public int Quantity { get; set; }
        public Product Product { get; set; }

    }
}