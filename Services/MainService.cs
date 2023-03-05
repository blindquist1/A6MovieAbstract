using A5Movie.Services;
using ApplicationTemplate.Context;
using ApplicationTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace ApplicationTemplate.Services;

/// <summary>
///     Main program to run the user interface. Inherits from IMainService.
/// </summary>
public class MainService : IMainService
{
    public MainService()
    {

    }
    
    public void Invoke() // consider this your Program.cs Main
    {
        int menuSelection = 0;
        while (menuSelection != 4)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. List Movies");
            Console.WriteLine("2. List Shows");
            Console.WriteLine("3. List Videos");
            Console.WriteLine("4. Exit");
            Console.WriteLine();

            bool validEntry = false;

            //Keep looping through until user chooses a valid entry, an integer and between 1 and 4.
            while (!validEntry)
            {
                menuSelection = InputService.GetIntWithPrompt("Select an option: ", "Entry must be an integer");
                if (menuSelection < 1 || menuSelection > 4)
                {
                    Console.WriteLine("Entry must be between 1 and 4");
                }
                else
                {
                    validEntry = true;
                }
            }

            MediaContext context = new MediaContext();

            if (menuSelection == 1)
            {
                context.MoviesRead();
                context.MoviesDisplay();

            }
            else if (menuSelection == 2)
            {
                context.ShowsRead();
                context.ShowsDisplay();
            }
            else if (menuSelection == 3)
            {
                context.VideosRead();
                context.VideosDisplay();
            }

            if (menuSelection != 4)
            {
                Console.WriteLine();
            }
        }
    }
}
