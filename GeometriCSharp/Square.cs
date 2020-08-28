using System;

namespace GeometriCSharp
{
    public class Square
    {
        //creating an int and making it as 0 as default
        private int a = 0;

        //creating a get/set encapsulation
        public int A
        {
            get { return this.a; }
            set { this.a = value; }
        }
        
        //this is an empty default constructor
        public Square()
        {
         
        }
        
        //This is a constructor that sets the properti of a
        public Square(int a)
        {
            A = a;
        }
        
        //this is my method to find the perimeter
        public int FindePerimeter(int b)
        {
            a = 4 * b;

            return a;
        }
    }
}