using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProgramizExamplesPrivate
{
    class Student
    {
        private string name = "Sheeran";

        private void print()
        {
            Console.WriteLine("Hello from Student class");
        }
    }

    class Program
    {
        //static void Main(string[] args)
        //{


        //    // creating object of Student class
        //    Student student1 = new Student();

        //    // accessing name field and printing it
        //    Console.WriteLine("Name: " + student1.name);

        //    //Since the field and method are private, we are not able to access them from the Program class. Here, the code will generate the following error.
        //    // accessing print method from Student
        //    student1.print();

        //    Console.ReadLine();
        //}
    }
}
