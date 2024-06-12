// Code in Assembly2
using System;
//access Assembly1
using Assembly5;

namespace Assembly6
{

    //derived class of StudentName
    class Program : StudentName
    {
        static void Main(string[] args)
        {
            Program student = new Program();

            // accessing name field from Assembly1
            Console.Write(student.name);
            Console.ReadLine();
        }
    }
}