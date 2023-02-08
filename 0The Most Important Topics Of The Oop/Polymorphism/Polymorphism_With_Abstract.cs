// Abstract Class Shape 

abstract class shape2{

    protected int length;
    protected int width;
    public abstract int area2();
}



// Class Rectangle inherite Abstract Shape class
class Rectangle2:shape2{

    public Rectangle2(int len,int wid){
        length=len;
        width=wid;
    }


    // polymorphism techniqe (override)
    public override int area2()
    {
        Console.WriteLine("Area Of Rectangle");
        return this.length*this.width;
    }

}