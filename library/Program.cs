using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace bibliotek
{
    class Program
    {


       
        static void Main(string[] args)
        {
            // her oprettes mit gui projekt så jeg kan kalde min renderMenu metode
            gui Gui = new gui();

            // her oprettes der mine bøger 
            book thePhilosphersStone = new book("The Philosopher´s Stone",1997,870,1);
            book theChamperOfSecrets = new book("The Champer of Secrets",1998,341,2);
            book thePrisonerOfAzkaban = new book("The Prisoners of Azkaban",1999,435,3);
            book theGobletOfFire = new book("The Goblet of Fire",2000,734,4);
            book theOrderOfThePhoenix = new book("The Order of the Phoenix",2003,870,5);
            book theHalfBloodPrince = new book("The Half-Blood Prince",2005,652,6);
            book theDeathlyHallows = new book("The Deathly Hallows",2007,759,7);

            // her bliver der oprettet en stack til senere brug
            Stack userLoanBooks = new Stack();
            // her bliver der oprettet en array liste
            ArrayList Books = new ArrayList();
            
            // her tilføjes mine bøger til listen
            Books.Add(thePhilosphersStone);
            Books.Add(theChamperOfSecrets);
            Books.Add(thePrisonerOfAzkaban);
            Books.Add(theGobletOfFire);
            Books.Add(theOrderOfThePhoenix);
            Books.Add(theHalfBloodPrince);
            Books.Add(theDeathlyHallows);

            // min menu metode bliver kaldt
            Gui.renderMenu();

            


            bool start = false;
            // while loop til at kører indtil start er sat til true.
            while (!start)
            {

                int userinput = int.Parse(Console.ReadLine());
                
                // switch på userinput som switcher på hvad brugeren har valgt på menu´en
                switch (userinput)
                {
                   
                    case 1:
                        Console.Clear();
                        // udskriver alle bøger som er i listen
                        foreach (book booksInList in Books)
                        {
                            Console.WriteLine($"{booksInList.ReleaseNumber} : {booksInList.Name}");
                        }
                       
                        Thread.Sleep(2000);
                        Console.Clear();
                        Gui.renderMenu();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Which book would you like to loan ");

                        // udskriver alle bøger som er i listen
                        foreach (book bookInList in Books)
                            {
                                Console.WriteLine($"{bookInList.ReleaseNumber}: {bookInList.Name}");
                            }

                        int userinputLoanBook = int.Parse(Console.ReadLine());

                        // switch på userinputLoanBook som switcher på hvilen bog som brugeren har valgt som han / hun vil låne
                        switch (userinputLoanBook)
                        {
                            // hvis brugeren vil have bogen The Philosophers Stone så bliver den valgt her 
                            case 1:
                                Books.Remove(thePhilosphersStone);
                                userLoanBooks.Push(thePhilosphersStone);
                                Console.WriteLine($"{thePhilosphersStone.Name} has been added to your loan");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Gui.renderMenu();
                                break;

                            // hvis brugeren vil have bogen The Champer Of Secrets så bliver den valgt her 
                            case 2:
                                Books.Remove(theChamperOfSecrets);
                                userLoanBooks.Push(theChamperOfSecrets);
                                Console.WriteLine($"{theChamperOfSecrets.Name} has been added to your loan");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Gui.renderMenu();
                                break;

                            // hvis brugeren vil have bogen The Prisoner Of Azkaban så bliver den valgt her 
                            case 3:
                                Books.Remove(thePrisonerOfAzkaban);
                                userLoanBooks.Push(thePrisonerOfAzkaban);
                                Console.WriteLine($"{thePrisonerOfAzkaban.Name} has been added to your loan");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Gui.renderMenu();
                                break;

                            // hvis brugeren vil have bogen The Goblet Of Fire så bliver den valgt her 
                            case 4:
                                Books.Remove(theGobletOfFire);
                                userLoanBooks.Push(theGobletOfFire);
                                Console.WriteLine($"{theGobletOfFire.Name} has been added to your loan");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Gui.renderMenu();
                                break;

                            // hvis brugeren vil have bogen The order Of The Phoenix så bliver den valgt her 
                            case 5:
                                Books.Remove(theOrderOfThePhoenix);
                                userLoanBooks.Push(theOrderOfThePhoenix);
                                Console.WriteLine($"{theOrderOfThePhoenix.Name} has been added to your loan");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Gui.renderMenu();
                                break;

                            // hvis brugeren vil have bogen The Half-Blood Prince så bliver den valgt her 
                            case 6:
                                Books.Remove(theHalfBloodPrince);
                                userLoanBooks.Push(theHalfBloodPrince);
                                Console.WriteLine($"{theHalfBloodPrince.Name} has been added to your loan");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Gui.renderMenu();
                                break;

                            // hvis brugeren vil have bogen The Deathly Hallows så bliver den valgt her 
                            case 7:
                                Books.Remove(theDeathlyHallows);
                                userLoanBooks.Push(theDeathlyHallows);
                                Console.WriteLine($"{theDeathlyHallows.Name} has been added to your loan");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Gui.renderMenu();
                                break;
                        }
                        break;

                    case 3:
                        // udskriver de bøger som brugeren har valgt til udlån
                        foreach (book userBooks in userLoanBooks)
                        {
                            Console.WriteLine($"you have selected : {userBooks.Name}");
                        }
                        Thread.Sleep(2000);
                        Console.Clear();
                        Gui.renderMenu();
                        break;

                    case 4:
                        // looper igennem hver bog som brugeren har valgt og kører funktionerne
                        // peek og pop for at fjerne dem fra stacken
                        for (int i = 0; i < userLoanBooks.Count + 1; i++)
                        {

                            userLoanBooks.Peek();
                            userLoanBooks.Pop();
                            Console.WriteLine($"book has been loan ");

                        }

                        Thread.Sleep(4000);
                        Console.Clear();
                        Gui.renderMenu();
                        break;

                    // går ud a mit while loop og stopper programmet samt kører min ascii menu
                    case 5:
                        Console.Clear();

                        start = true;
                        break;
                }
                
            }
        }
    }
}
