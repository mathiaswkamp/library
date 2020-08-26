using System.Collections.Generic;

namespace bibliotek
{
    static public class BookManager
    {
        public static List<book> GetBooks()
        {
            return ServerManager.GetBooks();
        }
    }
}