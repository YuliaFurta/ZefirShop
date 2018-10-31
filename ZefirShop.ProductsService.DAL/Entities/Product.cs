namespace ZefirShop.ProductsService.DAL.Entities
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public long Price { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
