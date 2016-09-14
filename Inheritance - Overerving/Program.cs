using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance___Overerving
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dier, Dier");
            Dier d1 = new Dier();
            
            d1.Zing();
            d1.Groet();
            d1.Praat();
            //Console.ReadLine();
            Console.WriteLine("Dier, Hond");
            Dier d2 = new Hond();
            
            d2.Zing();
            d2.Groet();
            d2.Praat();
            //Console.ReadLine();
            Console.WriteLine("Hond, Hond");
            Hond h1 = new Hond();
            h1.Zing();
            h1.Groet();
            h1.Praat();
            Console.ReadLine();
        }
    }
}
