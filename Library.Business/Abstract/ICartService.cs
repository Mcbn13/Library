using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Book book);

        void RemoveFromCart(Cart cart, int bookId);

        List<CartLine> List(Cart cart);
    }
}
