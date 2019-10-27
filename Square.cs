    // This is how you declare a class
    //The format is {Access Modifier} "class" {ClassName} "{}"
    // public, private, protected, internal

    namespace SellingSquares {
        public class Square 
        {
            public int SideLength;
            //Strings are text
            public string Name;

            // If a function has the same name as the class it is a constructor
            // Constructors are called whenever you create a new copy of an object
            public Square(int sidelength, string name)
            {
                this.SideLength = sidelength;
                this.Name = name;
            }

            //This is a function, it returns type of int
            public int GetArea()
            {
                return SideLength * SideLength;
            }
            // Create a function that returns the paremter
            public int GetPerimeter(){
                return SideLength * 4; 
            }

            public override string ToString()
            {
                // you can also Add Strings

                // "Hello " + "World!" = "Hello World"
                // \n = newline
                // \r\n = newline
                // Environment.NewLine = newline
                // \t tab
                // you only need the "$" at the beginning of a string literal
                // a string literal is anything inside a ""

        

                return $"SquareName: {this.Name}\n" + $"Area: {GetArea()}\n" + $"Perimeter:{GetPerimeter()}" ;

                // >SquareName: darkness
                // 
            }
            

        }
    }
