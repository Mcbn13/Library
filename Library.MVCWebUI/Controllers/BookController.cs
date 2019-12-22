using Library.Business.Abstract;
using Library.MVCWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.MVCWebUI.Controllers
{
    public class BookController : Controller
    {
        IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public ActionResult Index(int page = 1, int category = 0)
        {
            var pageSize = 10;
            var books = _bookService.GetListByCategory(category);

            BookListViewModel model = new BookListViewModel
            {
                Books = books.Data.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(books.Data.Count / (double)pageSize),
                PageSize = pageSize,
                CurrentCategory = category,
                CurrentPage = page
            };
            return View(model);
        }
    }
}
