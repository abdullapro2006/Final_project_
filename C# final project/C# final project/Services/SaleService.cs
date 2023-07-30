using C__final_project.Data.Enums;
using C__final_project.Models;
using C__final_project.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__final_project.Services
{
    public class SaleService : IMarketableForSales
    {
        private List<Sale> sales;
        public List<Product> products;
        public List<Category> categories;
        public List<SaleItem> items;
        public SaleService()
        {
            sales = new();
        }
        public void AddSale(int productid,int quantity, DateTime Now)
        {
            List<SaleItem> tempItems = new List<SaleItem>();
            int option;

            do
            {
                var product = products.Find(x=> x.ID == productid);

                if(quantity <= 0)
                {
                    Console.WriteLine("Quantity can not be to equals to 0 and less than 0!");
                }

                else if(product == null)
                {
                    Console.WriteLine("Product not found!");
                }
                else if (product.Count < quantity)
                {
                    Console.WriteLine("Not enough quantity in stock!");
                }
                else
                {
                    var price = product.Price * quantity;
                    product.Count -= quantity;

                    var saleItem = new SaleItem(product, quantity);
                    tempItems.Add(saleItem);

                    Console.WriteLine("Product added succefuly  to the stock:)");
                }

                Console.WriteLine("Do you want to add one more product?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");

                while(!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid option!");
                    Console.WriteLine("Please enter option again!");
                }
                if(option == 1)
                {
                    Console.WriteLine("Enter product ID:");
                    productid = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter the quantity");
                    quantity = Convert.ToInt32(Console.ReadLine());
                }
            } while (option == 1);

            if(tempItems.Count > 0)
            {
                double sum = tempItems.Sum(item => item.Count * item.Product.Price);
                int totalQuantity = tempItems.Sum(item => item.Count);

                var sale = new Sale("Sale", sum, totalQuantity, Now, tempItems);
                sales.Add(sale);

                Console.WriteLine("Sale completed!");
            }
            else
            {
                Console.WriteLine("Sale canceled,no products added.");
            }
            

            
        }

        public List<Sale> GetSale()
        {
            return sales;
        }

        public  void ReturnProductFromSale(int id)
        {
            throw new NotImplementedException();
        }

        public  void ShowSalesByAmountRange(int amount)
        {
            throw new NotImplementedException();
        }

        public  void ShowSalesByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public void ShowSalesByDateRange(DateTime mindate, DateTime maxdate)
        {
            throw new NotImplementedException();
        }

        public void ShowSalesByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
