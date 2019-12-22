using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Entities.Concrete
{
    public class Publisher : IEntity
    {
        public int PublisherId { get; set; }

        public string PublisherName { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
