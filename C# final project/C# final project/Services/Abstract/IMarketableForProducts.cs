using C__final_project.Data.Enums;
using C__final_project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__final_project.Services.Abstract
{
    public interface IMarketableForProducts // IMarketable interface created for using these methods in other methods.
    {
        public List<Product> GetProducts();
        public int ReturnAllProduct();
        public int AddProduct(string name,double price,int count,string category);
        public int UpdateProduct(string choose);
        public int ShowProductInCategory(string choose);
        public int ShowProductByAmountRange(double minamount,double maxamount);
        public List<Product> FindProductByName(string name);
        public int DeleteProduct(int id);




    }
}
