using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace bibliotek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<book> books = BookManager.GetBooks();
            
            foreach (book book in books)
            {
                Console.WriteLine(book.BookTitle);
            }

        }
    }
}