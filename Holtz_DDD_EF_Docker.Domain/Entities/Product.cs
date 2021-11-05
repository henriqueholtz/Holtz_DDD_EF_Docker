namespace Holtz_DDD_EF_Docker.Domain.Entities
{
    public class Product : Base
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
