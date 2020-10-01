﻿using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program inserts text into a story to make new and interesting 
            stories based on the reader's inputs.
            Author: Tony DeMarco
            */


            // Let the user know that the program is starting:
            Console.WriteLine("The program is starting");

            // Give the Mad Lib a title:
            string title = "A New Dawn";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();
            Console.Write("Enter a adjective: ");
            string adj1 = Console.ReadLine();
            Console.Write("Enter a second adjective: ");
            string adj2 = Console.ReadLine();
            Console.Write("Enter a third adjective: ");
            string adj3 = Console.ReadLine();
            Console.Write("Enter a verb: ");
            string verb = Console.ReadLine();
            Console.Write("Enter a noun: ");
            string noun = Console.ReadLine();
            Console.Write("Enter a second noun: ");
            string noun2 = Console.ReadLine();
            Console.Write("Enter a animal: ");
            string animal = Console.ReadLine();
            Console.Write("Enter a food: ");
            string food = Console.ReadLine();
            Console.Write("Enter a fruit: ");
            string fruit = Console.ReadLine();
            Console.Write("Enter a superhero: ");
            string superhero = Console.ReadLine();
            Console.Write("Enter a country: ");
            string country = Console.ReadLine();
            Console.Write("Enter a dessert: ");
            string dessert = Console.ReadLine();
            Console.Write("Enter a year: ");
            string year = Console.ReadLine();

            // The template for the story:

            string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);
        }
    }
}
