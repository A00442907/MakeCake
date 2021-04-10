using CakeMake.Models;
using CakeMake.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeMake.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ICakeRepository _cakeRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ICakeRepository cakeRepository, ShoppingCart shoppingCart)
        {
            _cakeRepository = cakeRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int cakeId)
        {
            var selectedCake = _cakeRepository.GetAllCake.FirstOrDefault(c => c.CakeId == cakeId);

            if (selectedCake != null)
            {
                _shoppingCart.AddToCart(selectedCake, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int cakeId)
        {
            var selectedCake = _cakeRepository.GetAllCake.FirstOrDefault(c => c.CakeId == cakeId);

            if (selectedCake != null)
            {
                _shoppingCart.RemoveFromCart(selectedCake);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult IncreaseQuanInShoppingCart(int cakeId)
        {
            var selectedCake = _cakeRepository.GetAllCake.FirstOrDefault(c => c.CakeId == cakeId);



            if (selectedCake != null)
            {
                _shoppingCart.IncreaseQuanInCart(selectedCake);
            }



            return RedirectToAction("Index");
        }

        public RedirectToActionResult ClearCart()
        {
            _shoppingCart.ClearCart();
            return RedirectToAction("Index");
        }
    }
}
