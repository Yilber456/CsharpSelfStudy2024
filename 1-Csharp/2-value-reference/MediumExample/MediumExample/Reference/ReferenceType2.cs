using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumExample.Reference
{
    class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    internal class ReferenceType2
    {
        //static void Main(string[] args)
        //{
        //    void ModifyRectangle(Rectangle rect)
        //    {
        //        rect.Width = 10;
        //        rect.Height = 5;
        //    }

        //    Rectangle myRectangle = new Rectangle { Width = 20, Height = 15 };
        //    ModifyRectangle(myRectangle);

        //    Console.WriteLine($"Width: {myRectangle.Width}, Height: {myRectangle.Height}");
        //    // Output: Width: 10, Height: 5, since the method modifies the object directly
        //}
    }
}
