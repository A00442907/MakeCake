using CakeMake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeMake.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Cake> CakeOnSale { get; set; }
    }
}
