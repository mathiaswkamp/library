using System;

namespace bibliotek
{
    /// <summary>
    /// Denne klasse har en metode renderMenu() som udskriver min menu
    /// </summary>
    class gui
    {
        public void renderMenu()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("                   library                   ");
            Console.WriteLine("=============================================");

            Console.WriteLine("1. Show books available");
            Console.WriteLine("2. Loan a book");
            Console.WriteLine("3. Show your loans");
            Console.WriteLine("4. Complete loan");
            Console.WriteLine("5. Exit");
        }
    }
}