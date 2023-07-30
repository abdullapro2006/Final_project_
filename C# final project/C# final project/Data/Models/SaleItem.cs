using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__final_project.Data.Common;

namespace C__final_project.Models
{
   
    public class SaleItem : BaseEntity
    {
        private static int counter = 0;
     
        public int Count { get; set; }
        public Product Product { get; set; }
      


        public SaleItem(Product product,int count)
        {

            if (product.Count < count || count < 0)
           
             throw new ArgumentException($"Can not make a sale item of {count} {product.Name} which {product.Count} of its exist in the storage");
            
            Count = count;
            Product = product;
            ID = counter++;
           
            

        }
        public string GetCode()
        {
            return $"[p:{Product.Name}| c:{Count}#{ID}]";
        }

    }
}
