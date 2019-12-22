using Core.Utilities.Results;
using Library.Business.Abstract;
using Library.Business.Constants;
using Library.DataAccess.Abstract;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Business.Concrete
{
    public class BookManager : IBookService
    {
        private IBookDAL _bookDal;

        public BookManager(IBookDAL bookDal)
        {
            _bookDal = bookDal;
        }

        public IDataResult<Book> GetById(int bookId)
        {
            //Business codes
            return new SuccessDataResult<Book>(_bookDal.Get(filter: x => x.BookId == bookId));
        }

        public IDataResult<List<Book>> GetList()
        {
            //Business codes
            return new SuccessDataResult<List<Book>>(_bookDal.GetList().ToList());
        }

        public IDataResult<List<Book>> GetListByCategory(int categoryId)
        {
            //Business codes
            return new SuccessDataResult<List<Book>>(_bookDal.GetList(filter: x => x.CategoryId == categoryId || categoryId == 0).ToList());
        }

        public IResult Insert(Book book)
        {
            //Business codes
            _bookDal.Insert(book);
            return new SuccessResult(message: Messages.BookInserted);
        }

        public IResult Update(Book book)
        {
            //Business codes
            _bookDal.Update(book);
            return new SuccessResult(message: Messages.BookUpdated);
        }

        public IResult Delete(Book book)
        {
            //Business codes
            _bookDal.Delete(book);
            return new SuccessResult(message: Messages.BookDeleted);
        }
    }
}
