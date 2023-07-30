using C__final_project.Data.Enums;
using C__final_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
                Category category = (Category) Enum.Parse(typeof(Category), Console.ReadLine(),true);


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
                Console.WriteLine("Please enter name of product");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter ID:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter count:");
                int count = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter ");
                Console.WriteLine("Please enter price:");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter category:");
                Category category = ( Category) Enum.Parse(typeof(Category),Console.ReadLine(),true);
                productService.UpdateProduct(name,id,count,price,category);
                Console.WriteLine("Product updated succefuly!");

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
                Console.WriteLine("Product deleted succesfuly!");
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
                Category category = Category.Meat;
                Console.WriteLine(category);
                Category category1 = Category.Vegatables;
                Console.WriteLine(category1);
                Category category2 = Category.Coffee;
                Console.WriteLine(category2);
                Category category3 = Category.Oils;
                Console.WriteLine(category3);
                Category category4 = Category.Bread;
                Console.WriteLine(category4);
                Category category5 = Category.Tea;
                Console.WriteLine(category5);
                Category category6 = Category.Seafood;
                Console.WriteLine(category6);
                Category category7 = Category.Fruits;
                Console.WriteLine(category7);
                Category category8 = Category.Drinks;
                Console.WriteLine(category8);
                Category category9 = Category.Sauces;
                Console.WriteLine(category9);
                Console.WriteLine("Enter category:");
                Category categoryname = (Category)Enum.Parse(typeof (Category),Console.ReadLine(),true);

                var foundproducts = productService.ShowProductInCategory(categoryname);
                if(foundproducts.Count == 0)
                {
                    Console.WriteLine("No products found!");
                    return;
                }
                foreach (var product in foundproducts)
                {
                    Console.WriteLine($"Name:{product.Name}, ID:{product.ID}, Count:{product.Count}, Price:{product.Price}, Category:{product.Category}");
                }

              
                
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
               var foundproduct =  productService.ShowProductByAmountRange(minamount, maxamount);
                if(foundproduct.Count == 0)
                {
                    Console.WriteLine("No products found!");
                }
                foreach(var product in foundproduct)
                {
                    Console.WriteLine($"Name:{product.Name}, ID:{product.ID}, Count:{product.Count}, Price:{product.Price}, Category:{product.Category}");
                }
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
                Console.WriteLine("Product founded");

                if (foundproducts.Count == 0)
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
