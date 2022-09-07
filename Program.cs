public class Program{
    
    public static void Main (string[] args){
         Shop myShop = new Shop();
         myShop.Name = "มีเดียทางการค้า";
         myShop.Number = "7124574235102";
         myShop.OwnerName = "นาย เจมส์ ทองดี";
         myShop.RegisteredValue = 1000000;
         PrintShopInfoemation(myShop);

    } 

    static void PrintShopInfoemation(Shop shop){
        Console.WriteLine("----------- Shop Information ----------");
        Console.WriteLine("Name: {0}", shop.Name);
        Console.WriteLine("Number: {0}", shop.Number);
        Console.WriteLine("Owner Name: {0}", shop.OwnerName);
        Console.WriteLine("Registered Value: {0}", shop.RegisteredValue);
        Console.WriteLine("---------------------------------");
    }
}

public class Shop {
    public string Name;
    public string Number;
    public string OwnerName;
    public int RegisteredValue;

}
