using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Entities.Concrete
{
    public class User : IEntity
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public string Adress { get; set; }

        public virtual ICollection<Loan> Loan { get; set; }
    }
}
