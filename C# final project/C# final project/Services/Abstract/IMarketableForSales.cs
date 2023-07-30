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
        public void AddSale(int id,int amount, DateTime date);
        public void ReturnProductFromSale(int id);
        public void ShowSalesByDateRange(DateTime mindate, DateTime maxdate);
        public void ShowSalesByDate(DateTime date);
        public void ShowSalesByAmountRange(int amount);
        public void ShowSalesByID(int id);


    }
}
