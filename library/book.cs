using System;
using System.Collections.Generic;

namespace bibliotek
{


    /// <summary>
    /// class book
    /// attributes, name, yearReleased, bookSize, releaseNumber
    /// constructoren tager alle mine attributer med til når der bliver oprettet et nyt
    /// objekt af typen book.
    /// </summary>
    class book
    {

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int yearReleased;

        public int YearReleased
        {
            get { return yearReleased; }
            set { yearReleased = value; }
        }

        private int bookSize;

        public int BookSize
        {
            get { return bookSize; }
            set { bookSize = value; }
        }

        private int releaseNumber;

        public int ReleaseNumber
        {
            get { return releaseNumber; }
            set { releaseNumber = value; }
        }



        public book(string name, int yearreleased, int booksize, int number)
        {
            this.bookSize = booksize;
            this.name = name;
            this.yearReleased = yearreleased;
            this.releaseNumber = number;

        }

    }
}