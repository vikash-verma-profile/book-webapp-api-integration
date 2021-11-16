using Book_Api.Entity;
using Book_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Book_Api.Controllers
{
    public class BookController : ApiController
    {
        //Getting book List
        BookDBEntities db =new  BookDBEntities();
        [HttpGet]
        public IEnumerable<Book> GetBookList()
        {
            List<Book> booklist = new List<Book>();
            var booksdata = db.tblBooks.ToList();
            foreach (var item in booksdata)
            {
                booklist.Add(new Book { BookId = item.ID, BookName = item.BookName, BookAuthor = item.BookAuthor });
            }
            return booklist;
        }
    }
}
