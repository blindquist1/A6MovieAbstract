using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate.Models
{
    public class Show : Media
    {
        public int Season { get; set; }
        public int Episode { get; set; }
        public string[] Writers { get; set; }

        public override void Display() //Will override Display() in Media
        {
            System.Console.WriteLine($"Title: {Title} Season: {Season} Episode: {Episode} Writers: {string.Join(", ", Writers)}");
        }
    }
}
