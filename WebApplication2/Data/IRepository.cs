using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication2.Data.Entities;

namespace WebApplication2.Data
{
    public interface IRepository
    {
        void AddProduct(Product product);

        IEnumerable<Product> GetProducts();

        bool ProductExists(int id);

        void RemoveProduct(Product product);

        Task<bool> SaveAllAsync();

        void UpdateProduct(Product product);

        Product GetProduct(int id);
    }
}