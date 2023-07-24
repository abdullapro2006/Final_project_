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
        public SaleItem(int count,string product)
        {
            Count = count;
            Product = product;
            ID = counter;
            counter++;
        }
        public int Count { get; set; }
        public string Product { get; set; }

    }
}
