using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Librarian : Person
    {
        Book ProvideBook()
        {
            var book = new Book("Ray Bradbery", "Book");
            book.Title = "Four Seasons";
            return book;
        }

    }
}
