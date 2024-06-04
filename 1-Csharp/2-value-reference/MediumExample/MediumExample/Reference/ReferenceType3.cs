using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumExample.Reference
{

    internal class ReferenceType3
    {
        static void Main(string[] args)
        {
            Person person1 = new Person { Name = "Alice" };
            Person person2 = person1; // Both person1 and person2 now refer to the same object

            Person person3 = new Person { Name = "Alice" };
            Person person4 = new Person { Name = "Alice" };

            bool isEqual1 = person1 == person2; // true, since both variables refer to the same object
            bool isEqual2 = person1 == person3; // false, even though the properties are the same, they refer to different objects
            bool isEqual3 = person3 == person4; // false, since they refer to two different objects with different memory addresses

            Person[] array1 = { new Person { Name = "Alice" }, new Person { Name = "Bob" } };
            Person[] array2 = { new Person { Name = "Alice" }, new Person { Name = "Bob" } };

            bool areArraysEqual = array1.SequenceEqual(array2); // true, since their elements are equal
        }
    }
}
