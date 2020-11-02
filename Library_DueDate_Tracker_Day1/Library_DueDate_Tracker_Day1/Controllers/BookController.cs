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
        public static List<Book> Books = new List<Book>();
        public IActionResult Index()
        {
            return View();
        }
    }
}
