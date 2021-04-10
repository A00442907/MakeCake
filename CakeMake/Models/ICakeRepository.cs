using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeMake.Models
{
    public interface ICakeRepository
    {
        IEnumerable<Cake> GetAllCake { get; }
        IEnumerable<Cake> GetCakeOnSale { get; }
        Cake GetCakeById(int cakeId);
    }
}
