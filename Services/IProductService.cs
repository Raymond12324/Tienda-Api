using System.Collections.Generic;
using System.Threading.Tasks;
using Tienda_Api.Models;

namespace Tienda_Api.Services
{
    public interface IProductService
    {
        //Obtener todos los productos
        Task<ServiceResponse<List<Product>>> GetAllProducts();

        //Obtener rpducto especifico
        Task<ServiceResponse<Product>> GetProductById(int id);

        //Agregar Producto
        Task<ServiceResponse<Product>> AddProduct(Product product);

        //Actualizar producto
        Task<ServiceResponse<Product>> UpdateProduct(Product product);

        //Obtener todos los productos
        Task<ServiceResponse<List<Product>>> DeleteProduct(int id);
    }
}