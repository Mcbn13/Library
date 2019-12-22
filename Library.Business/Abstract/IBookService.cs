using Core.Utilities.Results;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business.Abstract
{
    public interface IBookService
    {
        IDataResult<Book> GetById(int bookId);

        IDataResult<List<Book>> GetList();

        IDataResult<List<Book>> GetListByCategory(int categoryId);

        IResult Insert(Book book);

        IResult Delete(Book book);

        IResult Update(Book book);
    }
}
