using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__final_project.Services
{
    public class MenuServiceForSales
    {
        private static MenuServiceForSales menuServiceForSales = new MenuServiceForSales();

        public static void AddSale()
        {
            Console.WriteLine("Please enter ID:");
            int id = Convert.ToInt32(Console.ReadLine());
        }
    }
}
