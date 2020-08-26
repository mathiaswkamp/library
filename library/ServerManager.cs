using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace bibliotek
{
    public static class ServerManager
    {
        private static string cs =
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library;Integrated Security=True";


        public static List<book> GetBooks()

        {
            List<book> books = new List<book>();


            using (SqlConnection connection = new SqlConnection(cs))

            {
                connection.Open();

                SqlCommand sql = new SqlCommand("select bookid, booktitle, bookyear from books", connection);

                SqlDataReader rdr = sql.ExecuteReader();

                while (rdr.Read())
                {
                    int id = (int) rdr["bookid"];
                    
                    string title = (string) rdr["booktitle"];

                    int year = (int) rdr["bookyear"];

                    book b = new book() {BookID = id, BookTitle = title, BookYear = year};

                    books.Add(b);
                }
            }

            return books;
        }
    }
}