using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate.Models
{
    public abstract class Media //Can create fields here, can't instantiate an abstract class, reason for it is to have shared code
    {
        int Number;
        public int Id { get; set; }
        public string Title { get; set; }

        public virtual void Display() //"virtual" here, you CAN override it. Most commonly used.
        {
            System.Console.WriteLine($"Id: {Id}, Title: {Title}");
        }
    }


}
