using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Entities.Concrete
{
    public class Author : IEntity
    {
        public int AuthorId { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
