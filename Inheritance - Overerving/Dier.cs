using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance___Overerving
{
    class Dier
    {
        public Dier() 
        {
            Console.WriteLine("Dier Constructor is aangeroepen");
        }

        public void Praat()
        {
            Console.WriteLine("Dier Praat");
        }

        public void Groet()
        {
            Console.WriteLine("Dier Groet");
        }

        public virtual void Zing()
        {
            Console.WriteLine("Dier Zingt");
        }
    }
}
