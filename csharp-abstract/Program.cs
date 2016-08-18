using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Consultancy consultancy = new Consultancy() { Name = ".Net Security" };
            consultancy.Operate();

            Training training = new Training() { Name = "Introduction to C#" };
            training.Operate();

            Console.ReadLine();
        }
    }
}
