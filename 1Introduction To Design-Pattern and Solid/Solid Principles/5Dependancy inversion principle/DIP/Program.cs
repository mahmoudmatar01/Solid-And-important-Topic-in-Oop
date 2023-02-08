using System;
namespace Application
{
    class main{

        static void Main(string[]args){

            Notification mail1=new Notification(new Gmail());
            mail1.Send();

        }
    }
}