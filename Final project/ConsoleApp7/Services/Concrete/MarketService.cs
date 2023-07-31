using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;
using System.Collections.Generic;
using System.Linq;
using finalProject.Data.Enums;
using finalProject.Data.Models;
using finalProject.Services.Abstract;

namespace finalProject.Services.Concrete
{
    public class MarketService : IMarketable

    {
        private List<Product> products;
        private List<Sales> sales;
        private List<SaleItem> salesItem;


        public MarketService()
        {
            products = new List<Product>();
            sales = new List<Sales>();
            salesItem = new List<SaleItem>();
        }

        public int AddProduct(string name, decimal price, Categories category, int quantity)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new Exception("Name can't be empty!");
            if (price < 0) throw new Exception("Price can't be less than 0!");
            if (quantity < 0) throw new Exception("Quantity can't be less than 0!");

            var product = new Product(name, price, category, quantity);
            products.Add(product);
            return product.ID;
        }

        public int AddSale(int productId, int quantity, DateTime date)
        {
            List<SaleItem> salesItem = new List<SaleItem>();

            var prd = products.Find(x => x.ID == productId);

            if (quantity <= 0)
            {
                Console.WriteLine("Quantity can't be less than 0 or equal to 0 !  ");
            }
            else if (prd == null)
            {
                Console.WriteLine("Product not found.");
            }
            else if (prd.Quantity < quantity)
            {
                Console.WriteLine("Not enough product in stock.");
            }
            // here new Price(amount) of Sale = product's price * its quantity
            var price = prd.Price * quantity;

            //here we reduce products from storage
            prd.Quantity -= quantity;

            var saleItem = new SaleItem(prd, quantity);
            salesItem.Add(saleItem);
            var sale = new Sales(price, quantity, DateTime.Now);

            foreach (var item in salesItem)
            {
                sale.AddSaleItem(item);
            }
            sales.Add(sale);


            Console.WriteLine("Product added to the sale.");

         
            return sale.ID;
        }


        public List<Product> FindProductByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new Exception("Name can't be empty!");

            var foundProducts = products.Where(x => x.Name.ToLower().Trim() == name.ToLower().Trim()).ToList();

            return foundProducts;
        }

        public List<Sales> FindSalesByGivenID(int ID)
        {
            if (ID < 0)
            {
                Console.WriteLine("ID can't be less than 0!");
                return new List<Sales>();
            }

            var salesList = sales.Where(sale => sale.ID == ID).ToList();

            if (salesList.Count == 0)
            {
                Console.WriteLine($"No sale found with the given ID: {ID}");
            }

            return salesList;
        }

        public List<Product> GetProducts()
        {
            return products;
        }


        public List<Sales> GetSales()
        {
            return sales;
        }

        public void RemoveProduct(int ID)
        {
            if (ID < 0) throw new Exception("ID can't be less than 0!");
            int ProductIndex = products.FindIndex(x => x.ID == ID);
            if (ProductIndex == -1) throw new Exception("product not found");
            products.RemoveAt(ProductIndex);

        }

        public void RemoveSales(int ID)
        {
            {
                if (ID < 0)
                    throw new Exception("ID can't be less than 0!");

                int saleIndex = sales.FindIndex(x => x.ID == ID);
                if (saleIndex == -1)
                    throw new Exception("Sale not found");

                Sales removedSale = sales[saleIndex];

                foreach (SaleItem saleItem in removedSale.Items)
                {
                    // Find the product associated with the sale item
                    Product product = products.Find(x => x.ID == saleItem.Product.ID);

                    // Add the quantity back to the product's quantity
                    product.Quantity += saleItem.Quantity;
                }

                // Remove the sale from the sales list
                sales.RemoveAt(saleIndex);

            }
        }

        public void ReturnOfProduct(int saleID, int productID, int quantity)
        {
            {
                Sales sale = sales.Find(s => s.ID == saleID);
                if (sale == null)
                {
                    Console.WriteLine("Sale not found.");
                    return;
                }

                SaleItem saleItem = sale.Items.Find(s => s.Product.ID == productID);
                if (saleItem == null)
                {
                    Console.WriteLine("Product not found in the sale.");
                    return;
                }

                if (quantity > saleItem.Quantity)
                {
                    Console.WriteLine("Invalid quantity. Cannot return more than sold one.");
                    return;
                }

                // Adds the quantity of the product back to the sales
                saleItem.Quantity -= quantity;


                // Updates the total amount of the sale (it considers the returned product's price)
                sale.Amount -= saleItem.Product.Price * quantity;

                int productIndex = products.FindIndex(x => x.ID == productID);
                Product returnedProduct = products[productIndex];
                foreach (Product prd in products)
                {
                    // Adds the quantity back to the product's quantity
                    prd.Quantity += saleItem.Quantity;
                }

                Console.WriteLine("Product returned successfully from the sale.");
            }
        }


        public List<Product> ShowProductsByCategory(Categories category)
        {
            throw new NotImplementedException();
        }

        public List<Product> ShowProductsByPriceRanges(decimal minPrice, decimal maxPrice)
        {
            if (minPrice > maxPrice) throw new Exception("Min price can't be more than Max price!");

            return products.Where(x => x.Price >= minPrice && x.Price <= maxPrice).ToList();
        }

        public List<Sales> ShowSalesByDateRange(DateTime minDate, DateTime maxDate)
        {
            if (minDate > maxDate) throw new Exception("Min date cannot be greater than the Max date.");

            return sales.Where(s => s.Date >= minDate && s.Date <= maxDate).ToList();
        }

        public List<Sales> ShowSalesByExactDate(DateTime date)
        {
            var salesOnDate = sales.Where(sale => sale.Date.Date == date.Date).ToList();

            return salesOnDate;
        }

        public List<Sales> ShowSalesByPriceRanges(decimal minAmount, decimal maxAmount)
        {
            if (minAmount > maxAmount) throw new Exception("Min amount can't be more than Max amount!");

            return sales.Where(x => x.Amount >= minAmount && x.Amount <= maxAmount).ToList();
        }

        public void UpdateProduct(int ID, string name, decimal price, Categories category, int quantity)

        {
            if (ID < 0) throw new Exception("ID can't be less than 0!");
            if (string.IsNullOrWhiteSpace(name)) throw new Exception("Name can't be empty!");
            if (price < 0) throw new ArgumentOutOfRangeException("Price can't be less than 0!");
            if (quantity < 0) throw new Exception("Quantity can't be less than 0!");

            var product = products.FirstOrDefault(x => x.ID == ID);

            if (product == null) throw new Exception("Product not found!");

            product.Name = name;
            product.Price = price;
            product.Category = category;
            product.Quantity = quantity;

        }

    }
}