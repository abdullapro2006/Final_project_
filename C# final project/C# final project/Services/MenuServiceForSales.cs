using C__final_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__final_project.Services
{
    public class MenuServiceForSales
    {
        private static SaleService saleService = new SaleService();

        public static void MenuAddSale()
        {
            try
            {

                Console.WriteLine("Please enter ID:");
                int Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter quantity:");
                int quantity = Convert.ToInt32(Console.ReadLine());

                saleService.AddSale(Id, quantity, DateTime.Now);


            }
            catch (Exception ex)
            {

                Console.WriteLine($"Oops,error.{ex.Message}");
            }
            
            
            
            
               
            
        }
        public static void MenuReturnProduct() 
        {
        
        }
        public static void MenuRemoveSale() 
        { 
        
        }
        public static void MenuShowAllSales()
        {

        }
        public static void MenuShowSalesByDateRange()
        {

        } 
        public static void MenuShowSalesByAmountRange()
        {

        }
        public static void MenuShowSalesByDate()
        {

        }
        public static void MenuShowSalesByID()
        {
            Console.WriteLine("Please enter Sale's ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            saleService.ShowSalesByID(id);

        }

    }
}
