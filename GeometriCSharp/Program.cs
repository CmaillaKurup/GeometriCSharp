using System;

namespace GeometriCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Im fetching my class and sets the value
            Square findeP = new Square(5);
            Square findeP1 = new Square(7);
            Square findeP2 = new Square(3);
            Square findeP3 = new Square(500);

            //I write the results out to the console
            Console.WriteLine(findeP.FindePerimeter(findeP.A));
            Console.WriteLine(findeP.FindePerimeter(findeP1.A));
            Console.WriteLine(findeP.FindePerimeter(findeP2.A));
            Console.WriteLine(findeP.FindePerimeter(findeP3.A));

        }
    }
}