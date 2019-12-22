using System.Collections.Generic;
using Library.Entities.Concrete;

namespace Library.MVCWebUI.Models
{
    public class BookDeleteViewModel
    {
        public Book Book { get; set; }
        public List<Category> Categories { get; set; }
    }
}