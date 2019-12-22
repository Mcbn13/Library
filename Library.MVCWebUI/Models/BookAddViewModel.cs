using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.MVCWebUI.Models
{
    public class BookAddViewModel
    {
        public List<Category> Categories { get; internal set; }

        public Book Book { get; set; }
    }
}
