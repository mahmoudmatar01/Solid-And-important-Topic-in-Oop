﻿using System;
namespace Application{

			//    " Interface Segregation Principle ( ISP ) "

// 1- Client should not be force to depend on methods they do not use
  
// لحاجه معينه مسرجعليش حاجه انا مش عايزها اصلا فالحل اني اعمل كل تاسك لوحده في فانكشن مستقله وهو يقارب اول مبدأ overriding بمعني اني افصل كل جزء مستقل عن الجزء الاخر علشان لما  اجي اعمل


// 2- Avoid Fat InterFace " Fat interFace=> means the class that almost have all methods in software " 

// 3- Client must not implement unnecessary methods

// 4- divided the fat interFace into many interfaces each one have a necessary for it 

// 5- A client should never be forced to implement an interface that it doesn’t use, 
//     or clients shouldn’t be forced to depend on methods they do not use


    class main{
        static void Main(string []args){


            Console.WriteLine("my name is mahmoud");

        }
    }
}