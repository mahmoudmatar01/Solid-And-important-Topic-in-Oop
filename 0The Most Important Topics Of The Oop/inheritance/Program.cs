using System;

namespace InheritanceApplication{
    class main{

        static void Main(string[] args){

            // rectangle object 
            Rectangle rectangle=new Rectangle();

            // this object can access all attribute int base class
            rectangle.SetLength(3);  //length=3
            rectangle.SetWidth(4);  // width=4
            
            int length=rectangle.GetLength();
            int width=rectangle.GetWidth();

            Console.WriteLine("Rectangle length = "+length);
            Console.WriteLine("Rectangle Width = "+width);


            int Area=rectangle.rectangleArea();
            Console.WriteLine("Rectangle Area = "+Area);

        }

    }

}