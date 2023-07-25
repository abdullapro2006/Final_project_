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

        public void AddProduct(string name,double price,int count,Category category)
        {
            if (name == null) throw new Exception("Name can not be null!");
            if (price <= 0) throw new Exception("Price ca not be equals to 0 and less than 0");
            if(count <= 0) throw new Exception("Count can not be equals to 0 and less than 0");
            if(category == null) throw new Exception("Category can not be null");
            var product = new Product(name, price, count, category);
            products.Add(product);
        }



        public List<Product> FindProductByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new Exception("Name can not be null");
            var foundproducts = products.Where(x=> x.Name.ToLower().Trim() == name.ToLower().Trim()).ToList();
            return foundproducts;
        }

        public List<Product> GetProducts()
        {
            return products;
        }


        public List<Product> ShowProductByAmountRange(double minamount, double maxamount)
        {
            if (minamount <= 0) throw new Exception("Amount can not be equals to 0 and less than 0!");
            if (maxamount <= 0) throw new Exception("Amount can not be equals to 0 and less than 0!");
            if (minamount > maxamount) throw new Exception("Minamount can not be more than maxamount!");
            return products.Where(x=>  x.Price >= minamount && x.Price <= maxamount).ToList();
        }

        public List<Product> ShowProductInCategory(Category categoryname)
        {
            if (categoryname == null) throw new Exception("Categort name can not be null!");
            var foundproduct = products.Where(x=> x.Category == categoryname).ToList();
            return foundproduct;

        }

        public void UpdateProduct(string name,int id,int count,double price,Category category)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new Exception("Name can not be null!");
            if (id < 0) throw new Exception("ID can not be less than 0");
            if (count <= 0) throw new Exception("Count can not be equals to 0 and less than 0");
            if (price <= 0) throw new Exception("Proce can not be equals to 0 and less than 0");
            if (category == null) throw new Exception("Category can not be null!");
            var existingproduct = products.FirstOrDefault(x=> x.ID == id);
            if (existingproduct == null) throw new Exception("Product not found!");
            existingproduct.Price = price;
            existingproduct.Category = category;
            existingproduct.Name = name;
           
            
        }
        public void DeleteProduct(int id) 
        {
            if (id < 0) throw new Exception("ID can not be negative!");
            var existingproduct = products.FirstOrDefault(x=> x.ID == id);
            if (existingproduct == null) throw new Exception("Not found!");
            products = products.Where(x=> x.ID != id).ToList();
        }

    }
}
