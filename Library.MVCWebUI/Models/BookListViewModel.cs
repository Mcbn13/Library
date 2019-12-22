using Core.Utilities.Results;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.MVCWebUI.Models
{
    public class BookListViewModel
    {
        public List<Book> Books { get; set; }
        public List<Category> Categories { get; set; }
        public int PageCount { get; internal set; }
        public int PageSize { get; internal set; }
        public int CurrentCategory { get; internal set; }
        public int CurrentPage { get; internal set; }
    }
}
