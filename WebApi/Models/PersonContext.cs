using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        //add constructor
    }
}