public class CheckItem{

public bool checkAdditem(item item1){

    var itemquantity=Stock.items.Where(x => x.code==item1.code).FirstOrDefault().quantity;
    if(itemquantity>item1.quantity){
        return true;
    }
    return false;
}



}