using System;// This is an import

namespace SellingSquares
{
    // This is a comment
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Start");

            // First Square Example
           // Square anotherSquare = new Square(5, "darkness");
           // Console.WriteLine($"SquareName: {anotherSquare.Name}");
           // Console.WriteLine($"SquareArea: {anotherSquare.GetArea() }");
            // First Square Example End


// Say somthing dumb is happening here"
// <-- click the red ball to th eleft of the line #

           
           // ToString Example
           // var aSquare = new Square(5, "Pikachu");
           // Console.WriteLine(aSquare.ToString());


            // Bool Example
            int numberOfApples = 20;
            bool IsTrueOrFalse = 1 == 2;

            Console.WriteLine($"The value of IsTrueOrFalse is {IsTrueOrFalse}");


            //If Example
            if (numberOfApples > 10 ){
                Console.WriteLine("YOu have more than 10 apples");
            }

            //This is a for loop example

            // We are going to create squares with random sizes, and generated names
            // "i" is a variable, 6 is the number of loops, i++ increment
            // the variable "i" is not available outside the for loop
            for(int i = 0; i <= 6; i++)
            {
                Square x= new Square(i, $"SquareName-{i}");
                
                // When delcaring a variable
                // use the type of object e.g Square {Insert Variable name}

                Console.WriteLine(x.ToString());
                
            }

            Console.WriteLine("Program End");

        }
    }
}
