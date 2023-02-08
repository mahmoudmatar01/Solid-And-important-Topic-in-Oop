

//Absract base Class

abstract class shape{

//                                        (Abstraction)

    //1- Abstraction is the concept of object-oriented programming that “shows” only essential attributes and “hides” unnecessary information. 
    //   The main purpose of abstraction is hiding the unnecessary details from the users.
    //   Abstraction is selecting data from a larger pool to show only relevant details of the object to the user. 
    //   It helps in reducing programming complexity and efforts. 
    //   It is one of the most important concepts of OOPs.
    //2- Abstract classes contain abstract methods, which are implemented by the derived class
    //3- The derived classes have more specialized functionality. 
    //4- You cannot create an instance of an abstract class 
    //5- You cannot declare an abstract method outside an abstract class.

/////////////////////////////////////////////////////////////////////////////////////////////


//abstract class attributes and methods

 public int length;
 public int width;


abstract public void SetLength(int len);
abstract public void SetWidth(int wid);
abstract public int Area(int len,int wid);
abstract public int GetLength();
abstract public int  GetWidth();
abstract public void displayArea();
}