using Library.Business.Abstract;
using Library.Entities.Concrete;
using Library.MVCWebUI.Models;
using Library.MVCWebUI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.MVCWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IBookService _bookService;

        public CartController(
            ICartSessionService cartSessionService,
            ICartService cartService,
            IBookService bookService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _bookService = bookService;
        }

        public ActionResult AddToCart(int bookId)
        {
            var bookToBeAdded = _bookService.GetById(bookId).Data;

            var cart = _cartSessionService.GetCart();

            _cartService.AddToCart(cart, bookToBeAdded);

            _cartSessionService.SetCart(cart);

            TempData.Add("message", String.Format("Your book, {0}, was successfully added to the cart!", bookToBeAdded.Title));

            return RedirectToAction("Index", "Book");
        }

        public ActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            CartListViewModel cartListViewModel = new CartListViewModel
            {
                Cart = cart
            };
            return View(cartListViewModel);
        }

        public ActionResult Remove(int bookId)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart, bookId);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", String.Format("Your book was successfully removed from the cart!"));
            return RedirectToAction("List");
        }


        public ActionResult Complete()
        {
            var userDetailsViewModel = new UserDetailsViewModel
            {
                User = new User()
            };
            return View(userDetailsViewModel);
        }

        [HttpPost]
        public ActionResult Complete(User user)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message", String.Format("Thank you {0}, you order is in process", user.Name));
            return View();
        }
    }
}