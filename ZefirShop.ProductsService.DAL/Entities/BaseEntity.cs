using System;

namespace ZefirShop.ProductsService.DAL.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
