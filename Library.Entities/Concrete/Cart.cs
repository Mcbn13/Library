using System.Collections.Generic;
using System.Linq;

namespace Library.Entities.Concrete
{
    public class Cart
    {
        public Cart()
        {
            CartLines = new List<CartLine>();
        }
        public List<CartLine> CartLines { get; set; }

        public decimal Total
        {
            get { return CartLines.Sum(x => x.Book.LoanPrice * x.Quantity); }
        }
    }
}
