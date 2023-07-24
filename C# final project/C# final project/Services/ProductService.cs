using C__final_project.Data.Enums;
using C__final_project.Models;
using C__final_project.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__final_project.Services
{

    public class ProductService : IMarketableForProducts
    {
        private List<Product> products;
        public ProductService() 
        {
            products = new();
        }

        public int AddProduct(string name,double price,int count,string category)
        {
            throw new NotImplementedException();
        }



        public List<Product> FindProductByName(string name)
        {
            throw new NotImplementedException();

        }

        public List<Product> GetProducts()
        {
            return products;
        }



        public int ReturnAllProduct()
        {
            throw new NotImplementedException();
        }

        public int ShowProductByAmountRange(double minamount, double maxamount)
        {
            throw new NotImplementedException();
        }

        public List<Category> ShowProductInCategory(string name)
        {
            throw new NotImplementedException();
        }

     

        public int UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
        public int DeleteProduct(int id) 
        {
            throw new NotImplementedException();
        }

        public int UpdateProduct(string choose)
        {
            throw new NotImplementedException();
        }

        int IMarketableForProducts.ShowProductInCategory(string choose)
        {
            throw new NotImplementedException();
        }
    }
}
