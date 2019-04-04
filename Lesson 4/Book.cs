using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    public class Book
    {
        public string Author { get; private set; }

        public string Title;

        private int _numberOfPages;
        DateTime _dateOfPublication;
        private string Category;

        public Book(string author, string title)
        {
            Author = author;
            Title = title;
        }

        public Book(string author)
        {
            Author = author;
        }

        void Read()
        {

        }
    }
}
