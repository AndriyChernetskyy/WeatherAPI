using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "FirstBook", Author = "FirstAuthor", Year = 2001 });
            db.Books.Add(new Book { Name = "SecondBook", Author = "SecondAuthor", Year = 2002 });
            db.Books.Add(new Book { Name = "ThirdBook", Author = "ThirdAuthor", Year = 2003 });

            base.Seed(db);
        }
    }
}