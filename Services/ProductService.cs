using System.Collections.Generic;
using System.Threading.Tasks;
using Tienda_Api.Models;

namespace Tienda_Api.Services
{
    public class ProductService : IProductService
    {
        public Task<ServiceResponse<Product>> AddProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<List<Product>>> DeleteProduct(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<List<Product>>> GetAllProducts()
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<Product>> GetProductById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<Product>> UpdateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}