using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.AdvertisementApp.DataAccess.Concrete;
using Udemy.AdvertisementApp.DataAccess.Context;
using Udemy.AdvertisementApp.DataAccess.Repository;
using Udemy.AdvertisementApp.Entities;

namespace Udemy.AdvertisementApp.DataAccess.UnitOfWork
{
    public class Uow : IUow
    {
        private readonly AdvertisementContext _context;

        public Uow(AdvertisementContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_context);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();

        }
        public interface IUow
        {
            IRepository<T> GetRepository<T>() where T : BaseEntity;
            Task SaveChangesAsync();
        }
    }
}