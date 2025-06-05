using System.Collections.Generic;
using System.Linq;
using BusinessObjects;

namespace DataAccessObjects
{
    public class ProductDAO
    {
        private static List<Product> ListProducts;
        public ProductDAO()
        {
            Product chai = new Product(1, "chai", 3, 12, 18);
            Product chang = new Product(2, "chang", 19, 17, 40);
            Product aniseed = new Product(3, "aniseed syrup", 10, 13, 70);
            ListProducts = new List<Product>
            {
                chai,
                chang,
                aniseed
            };
        }
        public List<Product> GetProducts()
        {
            return ListProducts;
        }
        public static List<Product> GetProducts()
        {
            var listProducts = new List<Product>();
            try
            {
                using var db = new MyStoreContext();
                listProducts = db.Products.ToList();
            }
            catch (Exception e) { }
            return listProducts;
        }
        public void SaveProduct (Product p)
        {
            ListProducts.Add(p);
        }
        public void UpdateProduct (Product product)
        {
            foreach (Product p in ListProducts.ToList())
            {
                if (p.ProductId == product.ProductId)
                {
                    p.ProductId = product.ProductId;
                    p.ProductName = product.ProductName;
                    p.UnitPrice = product.UnitPrice;
                    p.UnitsInStock = product.UnitsInStock;
                    p.CategoryId = product.CategoryId;                               
                }
            }
        }
        public void DeleteProduct(Product product)
        {
            foreach (Product p in ListProducts.ToList())
            {
                if (p.ProductId == product.ProductId)
                {
                    ListProducts.Remove(p);
                }
            }
        }
        public Product GetProductById(int id)
        {
            foreach (Product p in ListProducts.ToList())
            {
                if (p.ProductId == id)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
