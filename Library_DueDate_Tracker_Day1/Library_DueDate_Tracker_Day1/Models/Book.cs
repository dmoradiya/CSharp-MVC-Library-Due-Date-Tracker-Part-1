using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_DueDate_Tracker_Day1.Models
{
    public class Book
    {
        public int ID { get; }
        public string Title { get; }
        public DateTime PublicationDate { get; }
        public DateTime CheckedOutDate { get; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public string Author { get; }
        public Book(int id, string title, string author, DateTime publicationDate, DateTime chechedOutDate)
        {
            ID = id;
            Title = title;
            Author = author;
            PublicationDate = publicationDate;
            CheckedOutDate = chechedOutDate;
            DueDate = CheckedOutDate.AddDays(14);
            ReturnedDate = null;

        }
    }
}
