using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;
using System.Data.Entity;

namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {
        BookContext db = new BookContext();

        // GET api/values
        public IEnumerable<Book> GetBooks()
        {
            return db.Books;
        }

        // GET api/values/5
        public Book GetBook(int id)
        {
            Book book = db.Books.Find(id);
            return book;
        }

        // POST api/values
        [HttpPost]
        public void CreateBook([FromBody]Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
        }

        
        [HttpPut]
        public void EditBook(int id, [FromBody]Book book)
        {
            if(id == book.Id)
            {
                db.Entry(book).State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        // DELETE api/values/5
        public void DeleteBook(int id)
        {
            Book book = db.Books.Find(id);
            if(book != null)
            {
                db.Books.Remove(book);
                db.SaveChanges();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
