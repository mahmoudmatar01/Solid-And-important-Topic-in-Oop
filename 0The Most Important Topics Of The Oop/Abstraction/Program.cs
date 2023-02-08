using System;

namespace AbstractionApplication {

    class main{
        static void Main(String[]args){


              // object of class
                Rectangle rectangle =new Rectangle();
               
              // set length value 
                rectangle.SetLength(4);
                int length=rectangle.GetLength();

              // set width value
               rectangle.SetWidth(10);
               int width=rectangle.GetWidth();
            
             // Get Area 
               int Area=rectangle.Area(length,width);
               rectangle.displayArea();
        }

        
    }


}