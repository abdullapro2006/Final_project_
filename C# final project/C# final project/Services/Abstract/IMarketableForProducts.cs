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
        public void AddProduct(string name,double price,int count,Category category);
        public void UpdateProduct(string name, int id, int count, double price, Category category);
        public List<Product> ShowProductInCategory(Category categoryname);
        public List<Product> ShowProductByAmountRange(double minamount,double maxamount);
        public List<Product> FindProductByName(string name);
        public void DeleteProduct(int id);




    }
}
