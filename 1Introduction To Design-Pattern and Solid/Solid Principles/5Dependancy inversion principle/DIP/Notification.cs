public class Notification {

IMessage mail;
public IMessage mail3;
public Notification(IMessage mail2){
    // by constructor
    this.mail=mail2;

    // by Attribute
    this.mail3=new Gmail();
}


public void Send(){
    // constructor return
    mail.Send();
    // attribute return
    mail3.Send();
}


}