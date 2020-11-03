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
            ViewBag.Books = Books;
            return View();
        }
        public IActionResult Details(int bookId)
        {
            GetBookByID(bookId);
            ExtendDueDateForBookByID(bookId);
            ViewBag.Books = Books;
            return View();
        }
        public IActionResult ExtendDueDate(int bookId)
        {
           
            ExtendDueDateForBookByID(bookId);
            
            return RedirectToAction("Details");
        }


        public static List<Book> Books = new List<Book>();
        public void CreateBook(int bookID, string title, string author, DateTime publicationDate, DateTime chechedOutDate)
        {
            if (bookID != 0)
            {
                Books.Add(new Book(bookID, title, author, publicationDate, chechedOutDate));
            }
            
        }

        // Returns the “Book” object with the given “ID” from the “Books” list.
        public Book GetBookByID(int bookId)
        {
            return Books.Where(x => x.ID == bookId).FirstOrDefault();
        }

        // Extensions are 7 days from today’s date.
        public DateTime ExtendDueDateForBookByID(int bookId)
        {

            return Books.Where(x=>x.ID == bookId).Select(x=>x.DueDate.AddDays(7)).SingleOrDefault();
        }

        // Sets the “ReturnedDate” of the “Book” object with the given “ID” to the current date.
        public void ReturnBookByID(int bookId)
        {
            
        }

        // Removes the “Book” object with the given “ID” from the “Books” list.
        public void DeleteBookByID(int bookid)
        {
             Books.Remove(GetBookByID(bookid));
        }
         
    }
}
