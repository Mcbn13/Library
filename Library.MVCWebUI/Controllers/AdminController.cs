using Library.Business.Abstract;
using Library.Entities.Concrete;
using Library.MVCWebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.MVCWebUI.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private IBookService _bookService;
        private ICategoryService _categoryService;

        public AdminController(IBookService bookService, ICategoryService categoryService)
        {
            _bookService = bookService;
            _categoryService = categoryService;
        }

        public ActionResult Index()
        {
            var bookListViewModel = new BookListViewModel
            {
                Books = _bookService.GetList().Data
            };
            return View(bookListViewModel);
        }

        public ActionResult Add()
        {
            var model = new BookAddViewModel
            {
                Book = new Book(),
                Categories = _categoryService.GetList().Data
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookService.Insert(book);
                TempData.Add("message", "Book was successfully added");
            }
            return RedirectToAction("Add");
        }

        public ActionResult Update(int bookId)
        {
            var model = new BookUpdateViewModel
            {
                Book = _bookService.GetById(bookId).Data,
                Categories = _categoryService.GetList().Data
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookService.Update(book);
                TempData.Add("message", "Book was successfully updated");
            }
            return RedirectToAction("Update");
        }

        public ActionResult Delete(int bookId)
        {
            var model = new BookDeleteViewModel
            {
                Book = _bookService.GetById(bookId).Data,
                Categories = _categoryService.GetList().Data
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookService.Delete(book);
                TempData.Add("message", "Book was successfully deleted");
            }
            return RedirectToAction("Index");
        }
    }
}

