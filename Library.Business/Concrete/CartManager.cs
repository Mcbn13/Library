using Library.Business.Abstract;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Business.Concrete
{
    public class CartManager : ICartService
    {
        public void AddToCart(Cart cart, Book book)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(x => x.Book.BookId == book.BookId);
            if (cartLine != null)
            {
                cartLine.Quantity++;
                return;
            }
            cart.CartLines.Add(new CartLine { Book = book, Quantity = 1 });
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }

        public void RemoveFromCart(Cart cart, int bookId)
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(x => x.Book.BookId == bookId));
        }
    }
}
