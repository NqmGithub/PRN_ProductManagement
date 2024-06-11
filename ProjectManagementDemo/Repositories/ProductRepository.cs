using BussinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        public void DeleteProduct(Product p)
        {
            productsDAO.DeleteProduct(p);
        }

        public Product GetProductById(int id)
        {
            return productsDAO.GetProductById(id);
        }

        public List<Product> GetProducts()
        {
            return productsDAO.GetProducts();
        }

        public void SaveProduct(Product p)
        {
            productsDAO.SaveProduct(p);
        }

        public void UpdateProduct(Product p)
        {
            productsDAO.UpdateProduct(p);
        }
    }
}
