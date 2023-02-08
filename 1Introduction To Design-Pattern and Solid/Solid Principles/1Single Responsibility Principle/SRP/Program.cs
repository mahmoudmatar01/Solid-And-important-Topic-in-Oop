using System;
namespace Application
{


//     1*the class should solve only one problem it shpuld have a single reason to change

//     2* Do one thing and do it well 

//     3*there should never be more than one reason for a class or function to change

//     4*class or Function Should Have one job

//     5*if we have a class that we change a lot, and for different reasons, 
//     then this class should be broken down into more classes, each handling a single concern

    class main{

        static void Main(String[]args){
        

            item item=new item();
            item.code="231";
            item.price=123;
            item.quantity=20;


            ShoppingCart cart=new ShoppingCart();
            cart.Additem(item);
            Console.WriteLine(item.code);
            Console.WriteLine(cart.Count());

        }
    }
    
}