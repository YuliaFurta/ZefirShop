using System;
using System.Collections.Generic;
using System.Text;
using ZefirShop.ProductsService.DAL.Context;
using ZefirShop.ProductsService.DAL.Repositories.Interfaces;

namespace ZefirShop.ProductsService.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProductsServiceContext _context;
        
        public void Save()
        {
            _context.SaveChanges();

        }
    }
}
