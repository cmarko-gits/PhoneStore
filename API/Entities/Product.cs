
using API.Entitiees.Specification;

namespace API.Entities
{
     public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public long? OldPrice { get; set; }
        public long Price { get; set; }
        public bool IsOnSale { get; set; }
        public Specification Specifications { get; set; }  // Specification kao kompleksni tip
        public int QuantityInStock { get; set; }
    }
}
