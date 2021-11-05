namespace Holtz_DDD_EF_Docker.Application.Dtos
{
    public class ProductDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
