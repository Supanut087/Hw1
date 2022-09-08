
    public class Program{
    
    public static void Main (string[] args){
        
         
         Shop myShop = new Shop();
         Console.Write(myShop.Name = "Please input Name :");
         myShop.Name = Console.ReadLine();

         Console.Write(myShop.Number = "Please input Number :");
         myShop.Number = Console.ReadLine();

         Console.Write(myShop.OwnerName = "Please input Owner Name :");
         myShop.OwnerName = Console.ReadLine();

         Console.Write( myShop.RegisteredValue = "Please input Registered :");
         var RegisteredValue = int.Parse(Console.ReadLine());

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


