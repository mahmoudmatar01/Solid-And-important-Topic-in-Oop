public class invoice{


      public void createinvoice(List<item>cart){
        var TotalPrice=cart.Sum(x=> x.price);
        Console.WriteLine("Total price = "+TotalPrice);
    }

}