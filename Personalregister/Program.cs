using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Personalregister");
            var personal1 = new Personal();
            
            personal1.getPersonal("Martin", 25000);
            Console.WriteLine("Namn: " + personal1.namn + " " + "Lön: " + personal1.lön);
        }
    }
}
