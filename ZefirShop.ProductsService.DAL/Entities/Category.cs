using System.Collections.Generic;

namespace ZefirShop.ProductsService.DAL.Entities
{
    public class Category : BaseEntity
    {
        public string Title { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
    }
}
