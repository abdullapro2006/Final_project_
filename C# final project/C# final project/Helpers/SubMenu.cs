using C__final_project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__final_project.Helpers
{
    public  class SubMenu
    {
        public static void ProductSubMenu()
        {
            Console.Clear();
            int option;

            do
            {
                Console.WriteLine("1. Add new product");
                Console.WriteLine("2. Update product");
                Console.WriteLine("3. Delete product");
                Console.WriteLine("4. Show all products");
                Console.WriteLine("5. Show products by category");
                Console.WriteLine("6. Show products by amount range");
                Console.WriteLine("7. Find product by name");
                Console.WriteLine("0. Go back");
                Console.WriteLine("------------------------");
                Console.WriteLine("Please, select an option:");
                Console.WriteLine("------------------------");

                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Please, enter a valid option:");
                    Console.WriteLine("------------------------");
                }

                switch (option)
                {
                    case 1:
                        MenuServiceForProducts.MenuAddProduct();
                        break;
                        case 2:
                            MenuServiceForProducts.MenuUpdateProduct();
                        break;
                        case 3:
                            MenuServiceForProducts.MenuDeleteProduct();
                        break;
                    case 4:
                        MenuServiceForProducts.MenuShowProducts();
                        break;
                        case 5:
                            MenuServiceForProducts.MenuShowProductInCategory();
                        break;
                        case 6:
                            MenuServiceForProducts.MenuShowProductsByAmountRange();
                        break;
                        case 7:
                            MenuServiceForProducts.MenuFindProductByName();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("No such option!");
                        break;
                }




            } while (option != 0);

        }




        public static void SaleSubMenu()
        {
            Console.Clear();
            int option;

            do
            {
                Console.WriteLine("1. Add new sale");
                Console.WriteLine("2. Return product");
                Console.WriteLine("3. Remove sale");
                Console.WriteLine("4. Show all sales");
                Console.WriteLine("5. Show sales by mindate and maxdate range");
                Console.WriteLine("6. Show sales by amount range");
                Console.WriteLine("7. Show sales by date range");
                Console.WriteLine("8. Show sales by ID");
                Console.WriteLine("0. Go back");
                Console.WriteLine("------------------------");
                Console.WriteLine("Please, select an option:");
                Console.WriteLine("------------------------");

                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Please, enter a valid option:");
                    Console.WriteLine("------------------------");
                }

                switch (option)
                {
                    case 1:
                        MenuServiceForSales.MenuAddSale();
                        break;
                    case 2:
                        MenuServiceForSales.MenuReturnProduct();
                        break;
                    case 3:
                        MenuServiceForSales.MenuRemoveSale();
                        break;
                        case 4:
                            MenuServiceForSales.MenuShowAllSales();
                        break;
                        case 5:
                            MenuServiceForSales.MenuShowSalesByDateRange();
                        break;
                        case 6:
                            MenuServiceForSales.MenuShowSalesByAmountRange();
                        break;
                        case 7:
                        MenuServiceForSales.MenuShowSalesByDate();
                        break;
                        case 8:
                            MenuServiceForSales.MenuShowSalesByID();
                        break;
                    case 0:
                        break;

                    default:
                        Console.WriteLine("No such option!");
                        break;
                }


            } while (option != 0);
        }
    }



}

