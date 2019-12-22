using System.Collections.Generic;
using Library.Entities.Concrete;

namespace Library.MVCWebUI.Models
{
    public class BookUpdateViewModel
    {
        public Book Book { get; set; }

        public List<Category> Categories { get; set; }
    }
}