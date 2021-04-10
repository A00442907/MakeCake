using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakeMake.Models;
using CakeMake.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CakeMake.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICakeRepository _cakeRepository;

        public HomeController(ICakeRepository cakeRepository)
        {
            _cakeRepository = cakeRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                CakeOnSale = _cakeRepository.GetCakeOnSale
            };

            return View(homeViewModel);
        }
    }
}