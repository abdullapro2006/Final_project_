using C__final_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__final_project.Services.Abstract
{
    public interface IMarketableForSales

    {
        public List<Sale> GetSale();
        public int AddSale(int amount, string saleitem, DateTime date);
        public int ReturnProductFromSale(int id);
        public int ShowSalesByDateRange(DateTime mindate, DateTime maxdate);
        public int ShowSalesByDate(DateTime date);
        public int ShowSalesByAmountRange(int amount);
        public int ShowSalesByID(int id);


    }
}
