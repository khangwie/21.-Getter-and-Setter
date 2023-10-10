using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Getter_and_Setter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            movie movie1 = new movie("Titanic", "Jim", "PG-13");
            movie movie2 = new movie("Unreleased", "Evans", "PG");

            Console.WriteLine(movie1.Rating);
            Console.ReadLine();
        }
    }
}
