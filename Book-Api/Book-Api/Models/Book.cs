using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Book_Api.Models
{
    public class Book
    {

        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
    }
}