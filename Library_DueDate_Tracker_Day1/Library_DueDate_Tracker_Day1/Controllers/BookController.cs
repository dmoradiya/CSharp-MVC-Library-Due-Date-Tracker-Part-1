using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library_DueDate_Tracker_Day1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

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
        public IActionResult Details(int bookId)
        {
            GetBookByID(bookId);
            ViewBag.Books = Books;
            return View();
        }


        public static List<Book> Books = new List<Book>();
        public void CreateBook(int bookID, string title, string author, DateTime publicationDate, DateTime chechedOutDate)
        {
            Books.Add(new Book(bookID, title, author, publicationDate, chechedOutDate));
        }

        // Returns the “Book” object with the given “ID” from the “Books” list.
        public Book GetBookByID(int bookId)
        {
            return Books.Where(x => x.ID == bookId).FirstOrDefault();
        }

        // Extensions are 7 days from today’s date.
        //public Book ExtendDueDateForBookByID()
        //{
           
        //}

        // Sets the “ReturnedDate” of the “Book” object with the given “ID” to the current date.
        public void ReturnBookByID()
        {

        }

        // Removes the “Book” object with the given “ID” from the “Books” list.
        public void DeleteBookByID()
        {

        }
    }
}
