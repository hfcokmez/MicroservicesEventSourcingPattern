using System;
namespace EventSourcing.API.DTOs
{
    public class CreateProductDTO
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
    }
}
