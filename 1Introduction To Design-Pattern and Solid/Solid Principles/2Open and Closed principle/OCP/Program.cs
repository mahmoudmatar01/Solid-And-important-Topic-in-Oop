using System;
    namespace  Application
    {

//                          (" Open and Closed principle ")
//  1- the open / closed principle states that software entities.

// 2- Classes , Modules , Function ,etc Should be open for extension ,but closed for modification .

// 3- Any functionality should be done by adding new classes instead of changing existing one


//                            (" How To implement OCP ")
// 1- one may achieve this by adding  new functionality to derived class
// 2- or allow client to access the original class with Abstract or InterFace Class
//      and Create Anew class inheritance from Abstract Class or interface class
//      and add  a new functionality into this new class 



 

        class main{
            static void Main(string[]args){
                    
                    Manger manger=new Manger();
                    manger.name="mahmoud";
                    manger.id="1";
                    manger.BasicSalary=100;
                    Console.WriteLine(manger.ToString()+"\n"+
                    "his total Salary ="
                    +manger.CalcHourBouns(5));


                    NormalEmployee employee=new NormalEmployee();
                    employee.name="ahmed";
                    employee.BasicSalary=100;
                    employee.id="2";
                    Console.WriteLine(employee.ToString()+"\n"+
                    "his total Salary ="
                    +employee.CalcHourBouns(5));

            }
        }        
    }
