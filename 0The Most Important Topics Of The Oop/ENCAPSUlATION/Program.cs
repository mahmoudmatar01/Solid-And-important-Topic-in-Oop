using System;

/// <summary>
/// Main Class 
/// </summary>

namespace RectangleApplication
{
 class main
    {
 static void Main(string[] args)
        {

            Rectangle rectangle=new Rectangle();

            // when i need to used length and with never uses this way because they are private

            // rectangle.rectanglelength=12;  => Error
            // rectangle.rectangleWidth=14;  => Error

            // But use Set And Get Methods
            rectangle.setLength(12);  // rectangle_Length=12
            rectangle.setWidth(3);   // rectangle_Width=3

            // to get length and with values use get method
            int length=rectangle.getLength();
            int width=rectangle.getWidth();

            Console.WriteLine(length); 
            Console.WriteLine(width); 


            // to calculate rectangle Area 
            int Area=rectangle.Area();
            Console.WriteLine(Area);

          
            
        }
    }
}