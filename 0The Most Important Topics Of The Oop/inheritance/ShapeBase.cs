// BaseClass

class shape{

    //                                (Inheritance)
    // 1- One of the most important concepts in object-oriented programming is inheritance. 
    // 2- Inheritance allows us to define a class in terms of another class,
    //     which makes it easier to create and maintain an application
    // 3- This also provides an opportunity to reuse the code functionality and speeds up implementation time
    // 4- When creating a class, instead of writing completely new data members and member functions
//        the programmer can designate that the new class should inherit the members of an existing class
//     5- This existing class is called the base class, and the new class is referred to as the derived class. 


//                               (Base and Derived Classes)
// 1- A class can be derived from more than one class or interface
// 2- which means that it can inherit data and functions from multiple base classes or interfaces


//              (The syntax used in C# for creating derived classes is as follows)

    // <acess-specifier> class <base_class_name> { 
    //  ... class Attribute
    // } 
    // class <derived_class> : <base_class_name> { 
    //  ... class Attribute
    // } 

//////////////////////////////////////////////////////////////////////////////////////////


// Base Class Attriutes

private int width;
private int length;

public void SetWidth(int wid){
    this.width=wid;
}

public void SetLength(int len){
    this.length=len;
}

public int GetLength(){
    return this.length;
}

public int GetWidth(){
    return this.width;
}


}