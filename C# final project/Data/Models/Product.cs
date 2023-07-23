using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__final_project.Data.Common;

namespace C__final_project.Models
{

    public class Product : BaseEntity
    {
        private  int counter = 0;


        public Product(string name,double price,int count)
        {
            Name = name;
            Price = price;
            Count = count;
            ID = counter;
            count++;
        }


        public string  Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
    }
}
