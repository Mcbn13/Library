using Core.DataAccess;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.DataAccess.Abstract
{
    public interface IUserDAL : IEntityRepository<User>
    {

    }
}
