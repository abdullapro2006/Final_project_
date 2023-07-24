using C__final_project.Models;
using C__final_project.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__final_project.Services
{
    public class SaleService : IMarketableForSales
    {
        private List<Sale> sales;
        public SaleService()
        {
            sales = new();
        }
        public int AddSale(int amount, string saleitem, DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<Sale> GetSale()
        {
            throw new NotImplementedException();
        }

        public int ReturnProductFromSale(int id)
        {
            throw new NotImplementedException();
        }

        public int ShowSalesByAmountRange(int amount)
        {
            throw new NotImplementedException();
        }

        public int ShowSalesByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public int ShowSalesByDateRange(DateTime mindate, DateTime maxdate)
        {
            throw new NotImplementedException();
        }

        public int ShowSalesByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
