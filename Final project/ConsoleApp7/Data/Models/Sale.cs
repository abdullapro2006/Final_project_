using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using finalProject.Data.Common;

namespace finalProject.Data.Models
{
    public class Sales : BaseEntity
    {
        private static int count = 0;

        public Sales(decimal amount, int quantity, DateTime date)
        {
            Amount = amount;
            Date = date;
            Quantity = quantity;
            Items = new List<SaleItem>();

            ID = count;
            count++;


        }


        public Sales(decimal amount, List<SaleItem> items, DateTime date)
        {
            Amount = amount;
            Items = items;
            Date = date;
            ID = count;
            count++;
        }
        public decimal Amount { get; set; }
        public List<SaleItem> Items { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }

        public void AddSaleItem(SaleItem saleitem)

        {
            Items.Add(saleitem);
        }

    }
}