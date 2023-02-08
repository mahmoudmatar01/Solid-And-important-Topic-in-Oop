public class ShoppingCart:CheckItem{

    public List<item>Cart=new List<item>();

    public void Additem(item item){

        if(checkAdditem(item)){
            Cart.Add(item);
            Console.WriteLine(item.code+" Added To Cart");
        }
    }


    public void RemoveItem(item item){
        if(Cart.Contains(item)){
            Cart.Remove(item);
        }
    }

    public int Count(){
        return Cart.Count;
    }

  


}