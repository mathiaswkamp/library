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
    public class book
    {


        public int BookID { get; set; }
        public int BookYear { get; set; }
        public string BookTitle { get; set; }
        
        //public book(string name, int yearreleased, int booksize)
        //{
        //    this.bookSize = booksize;
        //    this.name = name;
        //    this.yearReleased = yearreleased;
        //}
    }
}