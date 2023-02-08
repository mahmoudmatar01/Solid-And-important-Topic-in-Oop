

/// <summary>
/// Rectangle Operations Class 
/// </summary>
public class Rectangle{

//                           (Encapsulation Overview)

// 1- is one of the fundamentals of OOP (object-oriented programming).
// 2- It refers to the bundling of data with the methods that operate on that data.
// 3-  Encapsulation is used to hide the values or state of a structured data object inside a class, 
//     preventing unauthorized parties’ direct access to them.
// 4- Publicly accessible methods are generally provided in the class (so-called getters and setters) to access the values, 
//    and other client classes call these methods to retrieve and modify the values within the object.
// 5- Encapsulation is implemented by using access specifiers. An access specifier defines 
//    the scope and visibility of a class member. C# supports the following access specifiers 

        // Public 
        // Private 
        // Protected  
        // Internal  
        // Protected internal 


//   1* (Public Access Specifier)
//         - Public access specifier allows a class to expose its member variables and member 
//          functions to other functions and objects
//         - Any public member can be accessed from outside the class. 

//   2* (Private Access Specifier)
//         -Private access specifier allows a class to hide its member variables and member 
//          functions from other functions and objects.
//         - Only functions of the same class can access its private members. 
//           Even an instance of a class cannot access its private members.

//   3* (Protected Access Specifier)
//         -Protected access specifier allows a child class to access the member variables and 
//          member functions of its base class.
//         -This way it helps in implementing inheritance.

//   4* (Internal Access Specifier)
//         -Internal access specifier allows a class to expose its member variables and member 
//          functions to other functions and objects in the current project

//   5* (Protected Internal Access Specifier)
//         -The protected internal access specifier allows a class to hide its member variables and 
//          member functions from other class objects and functions, except a child class within 
//          the same application


// private Accsess Specifier Example 
private int rectanglelength;
private int rectanglewidth;


// public Access Specifier Example 
public int Area(){
    return this.rectanglelength*this.rectanglewidth;
}

// protecte Access Specifier Example 
protected int Perimeter(){
    return (this.rectanglelength+this.rectanglewidth)*2;
}

// public Access Specifier Example
public int getLength(){
    // this Function to get private length and use it in this Application 
    return this.rectanglelength;
}

public int getWidth(){
    // this Function to get private width and use it in this Application 
   return this.rectanglewidth;
}



// internal Access Specifier Example
internal void setLength(int len){
    // this Function to set a new value in private length and use it in this Application 
    this.rectanglelength=len;
}

internal void setWidth(int wid){
    // this Function to set a new value in private Width and use it in this Application 
    this.rectanglewidth=wid;
}



}