using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__final_project.Data.Common;

namespace C__final_project.Models
{
    public class Sale : BaseEntity
    {
        private static int counter = 0;
      
        private int quantity;
       

        public DateTime Date { get; set; }
        public List<SaleItem> Items { get; set; }
        public int ProductCount { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public double Sum { get; set; }




        public Sale(string name,double sum, int quantity,DateTime date,List<SaleItem> items)
        {
            Name = name;
            Sum = sum;
            Quantity = quantity;
            Date = date;
            Items = items;
            ID = counter;
            counter++;
        }

      
    }

   
}
