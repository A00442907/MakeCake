using CakeMake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeMake.ViewModels
{
    public class CakeListViewModel
    {
        public IEnumerable<Cake> Cakes { get; set; }
        public string CurrentCategory { get; set; }
    }
}
