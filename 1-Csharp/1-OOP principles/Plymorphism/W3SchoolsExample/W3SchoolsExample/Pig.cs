using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3SchoolsExample
{
    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
}
