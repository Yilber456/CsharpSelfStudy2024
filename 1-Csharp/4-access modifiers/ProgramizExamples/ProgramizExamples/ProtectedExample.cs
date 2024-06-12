using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProgramizExamplesProtected
{
    class Student
    {
        protected string name = "Sheeran";
    }

    class Program
    {
        //static void Main(string[] args)
        //{
            

        //    // creating object of student class
        //    Student student1 = new Student();

        //    // accessing name field and printing it
        //    Console.WriteLine("Name: " + student1.name);
        //    //Since the field is protected, we are not able to access it from the Program class.
        //    Console.ReadLine();
        //}
    }
    // derived class
    class Program2 : Student
    {
        //static void Main(string[] args)
        //{

        //    // creating object of derived class
        //    Program2 program = new Program2();

        //    // accessing name field and printing it
        //    Console.WriteLine("Name: " + program.name);
        //    //Since the protected member can be accessed from derived classes, we are able to access name from the Program class.
        //    Console.ReadLine();
        //}
    }

}
