using BookWebApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BookWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public async Task<ActionResult> GetBookList()
        {
            List<Book> booklist = new List<Book>();
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080/");
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage res = await client.GetAsync("api/Book/GetBookList");

            if (res.IsSuccessStatusCode)
            {
                var bookresponse = res.Content.ReadAsStringAsync().Result;
                booklist = JsonConvert.DeserializeObject<List<Book>>(bookresponse);

            }
            return View(booklist);
        }
    }
}