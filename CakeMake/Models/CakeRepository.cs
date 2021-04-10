using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeMake.Models
{
    public class CakeRepository : ICakeRepository
    {
        private readonly AppDbContext _appDbContext;

        public CakeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Cake> GetAllCake 
        { 
           get
            {
                return _appDbContext.Cakes.Include(c => c.Category);
            }
        }

        public IEnumerable<Cake> GetCakeOnSale
        {
            get
            {
                return _appDbContext.Cakes.Include(c => c.Category).Where(p => p.IsOnSale);
            }
        }

        public Cake GetCakeById(int cakeId)
        {
            return _appDbContext.Cakes.FirstOrDefault(c => c.CakeId == cakeId);
        }
    }
}
