namespace Tienda_Api.Models
{
    public class ServiceResponse<T>
    {
        public T Data { get; set; }

        public string Message { get; set; }

        public bool Success { get; set;   }
    }
}