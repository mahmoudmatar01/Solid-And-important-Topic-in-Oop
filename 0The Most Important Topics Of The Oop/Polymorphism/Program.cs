using System;

namespace PolymorphismApplication{
class main
    {
 static void Main(string[] args)
        {


// Squrae object 
            Square square=new Square(12,3); // length =12 and width=3
            int squareArea=square.Area();
            Console.WriteLine(squareArea);
        

// Triangle object 
            Triangle triangle=new Triangle(3,2);  // length=3  and  width=2
            int triangleArea=triangle.Area();
            Console.WriteLine(triangleArea);        


// rectangle object 
            Rectangle2 rectangle2=new Rectangle2(6,2); // length=6  and Width =2
            int rectangleArea=rectangle2.area2();
            Console.WriteLine(rectangleArea);
        }
    }

}