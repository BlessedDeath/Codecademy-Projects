using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
    class Program
    {
        static void Main()
        {
            List<Language> languages = File.ReadAllLines("./languages.tsv")
              .Skip(1)
              .Select(line => Language.FromTsv(line))
              .ToList();

            foreach (var l in languages)
            {
                Console.WriteLine(l.Prettify());
            }

            var language = languages.Select(l => $"{l.Year} {l.Name} {l.ChiefDeveloper} {l.Predecessors}");

            var cSharp = languages.Where(l => l.Name == "C#");
            var cSharp2 = cSharp.Select(c => c.Prettify());
            foreach (var c2 in cSharp2)
            {
                Console.WriteLine(c2);
            }

            var microsoft = languages
              .Where(m => m.ChiefDeveloper.Contains("Microsoft"))
              .Select(m => m.Prettify());

            foreach (var m in microsoft)
            {
                Console.WriteLine(m);
            }

            var lisp = languages
              .Where(m => m.Predecessors.Contains("Lisp"))
              .Select(m => m.Prettify());

            foreach (var m in lisp)
            {
                Console.WriteLine(m);
            }

            var script = languages
              .Where(m => m.Name.Contains("Script"))
              .Select(m => m.Prettify());

            foreach (var m in script)
            {
                Console.WriteLine(m);
            }

            var count = languages.Count();
            Console.WriteLine(count);

            var year = languages
              .Where(m => m.Year > 1995 && m.Year < 2005)
              .Select(m => $"{m.Name} was invented in {m.Year}");

            foreach (var m in year)
            {
                Console.WriteLine(m);
            }

            PrettyPrintAll(languages);
            //PrintAll(languages);
        }

        public static void PrettyPrintAll(IEnumerable<Language> langs)
        {
            foreach (var l in langs)
            {
                Console.WriteLine(l.Prettify());
            }
        }

        //wasn't sure what to do with the last task so I've commented it out
        /*public static void PrintAll(IEnumerable<Object> sequence)
        {
          foreach (Object o in sequence)
          {
            Console.WriteLine(o);
          }
        }*/
    }
}
