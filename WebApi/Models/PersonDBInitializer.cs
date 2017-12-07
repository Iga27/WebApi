using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class PersonDBInitializer: DropCreateDatabaseAlways<PersonContext>
    {
        protected override void Seed(PersonContext db)
        {
            db.Persons.Add(new Person() { Age = 21, Name = "Richard", Surname = "Smith" });
            db.Persons.Add(new Person() { Age = 18, Name = "Andrew", Surname = "Red" });
            db.Persons.Add(new Person() { Age = 34, Name = "Alex", Surname = "Dubinski" });
            db.Persons.Add(new Person() { Age = 72, Name = "Dmitry", Surname = "Ivanov" });

            base.Seed(db);
        }
    }
}