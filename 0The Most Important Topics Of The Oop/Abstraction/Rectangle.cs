class Rectangle : shape
{
    
    public override int Area(int len,int wid)
    {
        return len*wid;
    }

    public override void displayArea()
    {
        Console.WriteLine("Area of Rectangle = "+length*width);
    }

    public override int GetLength()
    {
        return width;
    }

    public override int GetWidth()
    {
        return length;
    }

    public override void SetLength(int len)
    {
        length=len;
    }

    public override void SetWidth(int wid)
    {
        width=wid;
    }
}