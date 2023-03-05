using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate.Models
{
    public class Video : Media
    {
        public string[] Formats { get; set; }
        public int Length { get; set; }
        public int[] Regions { get; set; }

        public override void Display() //Will override Display() in Media
        {
            System.Console.WriteLine($"Title: {Title} Formats: {string.Join(", ", Formats)} Length: {Length} Regions: {string.Join(", ", Regions)}");
        }
    }
}
