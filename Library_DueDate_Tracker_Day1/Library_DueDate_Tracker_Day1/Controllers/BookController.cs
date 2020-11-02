using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library_DueDate_Tracker_Day1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library_DueDate_Tracker_Day1.Controllers
{
    public class BookController : Controller
    {
       
        public IActionResult Index()
        {
            return RedirectToAction("List");
        }
        public IActionResult List()
        {
            ViewBag.Books = Books;
            return View();
        }
        public IActionResult Create(int bookID, string title, string author, DateTime publicationDate, DateTime chechedOutDate)
        {
            CreateBook(bookID, title, author, publicationDate, chechedOutDate);

            return View();
        }
       
        public static List<Book> Books = new List<Book>();
        public void CreateBook(int bookID, string title, string author, DateTime publicationDate, DateTime chechedOutDate)
        {
            Books.Add(new Book(bookID, title, author, publicationDate, chechedOutDate));
        }
    }
}
