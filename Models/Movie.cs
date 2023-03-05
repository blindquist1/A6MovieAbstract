using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate.Models
{
    public class Movie : Media //This refers to the abstract class below
    {
        //These are properties
        public string[] Genres { get; set; }

        public override void Display() //Will override Display() in Media
        {
            System.Console.WriteLine($"Title: {Title} Genres: {string.Join(", ", Genres)}");
        }

        public override void Return()
        {
            throw new NotImplementedException();
        }
        /*
        public static implicit operator Movie(Movie v)
        {
            throw new NotImplementedException();
        }
        */
    }

    public class TicketOffice
    {
        List<Movie> Movies { get; set; }
        public void Search(string movieToSearchFor)
        {
            foreach(var movie in Movies)
            {
                //does my movie match movieToSearchFor
            }
        }
    }

}
