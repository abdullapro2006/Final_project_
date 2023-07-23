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

        public Sale(int amount,string saleitem,DateTime date)
        {
            Amount = amount;
            SaleItem = saleitem;
            Date = date;
            ID = counter;
            counter++;

        }
        public int Amount { get; set; }
        public string SaleItem { get; set; }
        public DateTime Date { get; set; }
    }
}
