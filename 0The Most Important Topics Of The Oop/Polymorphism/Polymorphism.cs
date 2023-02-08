

//                                  Base Class
class Shape{


//                              (Polymorphism)
//   1- The word polymorphism means having many forms.
//   2- In object-oriented programming paradigm, polymorphism is often expressed as 'one interface, multiple functions'. 
//   3- Polymorphism can be static or dynamic. In static polymorphism, the response to a function is determined at the compile time
//   4- it is decided at run-time.

//  "Static Polymorphism":-

//      * The mechanism of linking a function with an object during compile time is called early 
//        binding. It is also called static binding. C# provides two techniques to implement static 
//        polymorphism. They are −
              // -Function overloading 
              // -Operator overloading


//  " Function Overloading ":-
//     * You can have multiple definitions for the same function name in the same scope. The 
//       definition of the function must differ from each other by the types and/or the number of 
//       arguments in the argument list .
//     * You cannot overload function declarations that differ only by return type



// class Atributes
protected int width;
protected int length;


// class constructor 
public Shape(int len,int wid){
    this.length=len;
    this.width=wid;
}


public int Area(){
    Console.WriteLine("Area of this Shape");
    return this.length*this.width;
}

}





// class Triangle inhertience calss Shape And its All Attribute and methods
class Triangle : Shape
{
    public Triangle(int len, int wid) : base(len, wid)
    {
    }

    // polymorphism techniqe 
    public int Area(){
    Console.WriteLine("Area of Triangle :");
        return (this.width * this.length /2);
   }
}



// Class Square inheritence class Shape And its All Attribute And methods
class Square:Shape{
    
    //constructor
   public Square(int len,int width):base(len,width){}


    // polymorphism techniqe 
    public int Area(){
        Console.WriteLine("Area of Square");
        return this.length*this.width;
    }

}