using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumExample
{
    //In C#, you can define custom value types using the struct keyword. 
    //    These custom value types, also known as structs, allow you to create data structures that behave like built-in value types such as int, float, etc.
    //    However, they also provide the flexibility to include both value types and reference types as fields.

    public struct CustomValue
    {
        public int intValue;
        public string referenceValue;
    }

    internal class ValueType1
    {
        //static void Main(string[] args)
        //{
        //    // Create an instance of the custom value type (struct)
        //    CustomValue customData = new CustomValue();
        //    customData.intValue = 42;
        //    customData.referenceValue = "Hello, Struct!";

        //    // Print the values
        //    Console.WriteLine($"Int Value: {customData.intValue}");
        //    Console.WriteLine($"Reference Value: {customData.referenceValue}");
        //}
    }
}
