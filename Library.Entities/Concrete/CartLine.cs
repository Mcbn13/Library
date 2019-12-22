using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Entities.Concrete
{
    public class CartLine
    {
        public Book Book { get; set; }

        public int Quantity { get; set; }
    }
}
