namespace Module_7;

public static class Shop
{
    public static void PlaceOrder(Order<HomeShipping> order)
    {
        Console.WriteLine($"Заказ №{order.Number} оформлен");
    }
}