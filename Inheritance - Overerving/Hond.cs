using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance___Overerving
{
    class Hond : Dier
    {
        public Hond()
        {
            Console.WriteLine("Hond Constructor is aangeroepen");
        }

        public new void Groet()
        {
            Console.WriteLine("Hond Groet");
        }

        public override void Zing()
        {
            Console.WriteLine("Hond Zingt");
        }
    }
}
