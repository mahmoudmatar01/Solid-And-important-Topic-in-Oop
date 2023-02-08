using System;
namespace Appliication{



//                              " Liskov Substitution principle (LSP) "

// 1- if you have a class B inherits Class A then Class A should be replaceable by class B without any change

// لو انا عندي كلاس أ وفي كلاس ب يورث من الكلاس أ
// فانا لو في اي وقت بستخدم الكلاس أ في اي وقت لو بدلته بالكلاس ب فالبرامج يشتغل عادي بدون اي تغير 


// 2- create base class with virtual mithod and every class inherite the base class should override the method 
//      and change the return method would he like 

// 3- This means that every subclass or derived class should be substitutable for their base or parent class.


    class main{

        static void Main(string[]args){


            DataBase db=new DataBase();

            // posts List
            List<string>newposts= new List<string>();
            newposts.Add("mahmoud matar");
            newposts.Add("@mahmoud matar");
            newposts.Add("#mahmoud matar");

            // Post object 
            NormalPost post;

            foreach(var po in newposts){
                // DataBase db=new DataBase();


                if(po.StartsWith("#")){
                    post=new TagPost();
                }

                else if(po.StartsWith("@")){
                    post=new MentionPost();
                }
                else{
                    post=new NormalPost();
                }

                string result =post.CreatePost(po,db);
                Console.WriteLine(result);

            }


        }
    }
}