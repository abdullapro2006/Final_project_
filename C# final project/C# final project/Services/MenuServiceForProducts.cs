using C__final_project.Data.Enums;
using C__final_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__final_project.Services
{
    public class MenuServiceForProducts
    {
        private static ProductService productService = new ProductService();
        public static  void MenuAddProduct()
        {
            try
            {
                Console.WriteLine("Please enter name of product:");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter price of product: ");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter count of product:");
                int count =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter category:");
                string category = Console.ReadLine();


                productService.AddProduct(name,price,count,category);
                Console.WriteLine("Added new product succesfuly:)");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ooops,eror. {ex.Message}");
            }
        }
        public  static void MenuUpdateProduct()
        {
            try
            {
                Console.WriteLine("Please enter");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Oops,error. {ex.Message}");
            }
        }
        public static void MenuDeleteProduct()
        {
            try
            {
                Console.WriteLine("Please enter Product ID:");
                int id = Convert.ToInt32(Console.ReadLine());
                productService.DeleteProduct(id);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Oops,error. {ex.Message}");
            }
        }
        public static void MenuShowProducts()
        {
            var products = productService.GetProducts();
            if(products.Count == 0)
            {
                Console.WriteLine("No products yet!");
                return;
            }
            foreach (var product in products)
            {
                Console.WriteLine($"Name:{product.Name}, ID:{product.ID}, Count:{product.Count}, Price:{product.Price}, Category:{product.Category}");
            }
        }
        public static void MenuShowProductInCategory()
        {

            try
            {

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Oops,error. {ex.Message}");
            }

        }
        public static void MenuShowProductsByAmountRange() 
        {
            try
            {
                Console.WriteLine("Please enter minamount:");
                double minamount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter maxamount:");
                double maxamount = Convert.ToDouble(Console.ReadLine());
                productService.ShowProductByAmountRange(minamount, maxamount);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ooops,error.{ex.Message}");
            }
        }
        public static void MenuFindProductByName()
        {
            try
            {
                Console.WriteLine("Please enter name of product for search:");
                string name = Console.ReadLine();
                var foundproducts = productService.FindProductByName(name);

                if(foundproducts.Count == 0)
                {
                    Console.WriteLine("No products found");
                }
                foreach(var product in foundproducts)
                {
                    Console.WriteLine($"Name:{product.Name}, ID:{product.ID}, Count:{product.Count}, Price:{product.Price}, Category:{product.Category}");
                }
            } 
            catch (Exception ex)
            {

                Console.WriteLine($"Oops,error.{ex.Message}");
            }
        }
    }
}
