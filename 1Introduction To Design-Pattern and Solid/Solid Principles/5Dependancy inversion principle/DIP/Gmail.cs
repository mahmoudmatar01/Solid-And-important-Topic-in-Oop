public class Gmail : IMessage
{

    public string Address="Gamil";
    public string From="From Mail";
    public string To="To Mail";
    void IMessage.Send()
    {
        Console.WriteLine("Gmail mail");
    }
}




public class HotMail : IMessage
{

    public string Address="Gamil";
    public string From="From Mail";
    public string To="To Mail";
    void IMessage.Send()
    {
        Console.WriteLine("Hotmail mail");
    }
}