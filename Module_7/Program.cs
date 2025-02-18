namespace Module_7;

public static class OrderExtensions
{
    public static void GetOrderDescription(this Order<EmailShipping> order)
    {
        Console.WriteLine($"Заказу №{order.Number} доставка курьером не потребуется");
    }
    public static void GetOrderDescription(this Order<HomeShipping> order)
    {
        Console.WriteLine($"Заказу №{order.Number} потребуется доставка курьером");
    }
}

class Program
{
    static void Main()
    {
        var book1 = new PaperBook(
            isbn: "123-45-6789-0", 
            title: "Незнайка на Луне", 
            author: "Николай Носов", 
            price: 10000, 
            weight: 0.75f
            );
        var book2 = new PaperBook(
            isbn: "213-12-3112-2", 
            title: "Ночевала тучка золотая", 
            author: "Анатолий Приставкин",
            price: 5000, 
            weight: 1.0f
            );
        var ebook = new DigitalBook(
            isbn: "321-32-1321-3",
            title: "Палата №6",
            author: "Антон Чехов",
            price: 1000,
            downloadLink: "https://www.litres.ru/book6"
            );
        var gift = new GiftBook(
            isbn: "432-23-2344-2",
            title: "Война и мир",
            author: "Лев Толстой"
            );

        var cart1 = new Cart<Book>();
        cart1.Add(book1);
        cart1.Add(book2);
        
        Console.WriteLine($"1. {cart1}");
        
        for (int i = 0; i < cart1.Count; i++)
        {
            Console.WriteLine($"Товар {i+1}: {cart1[i]}");
        }
        
        var cart2 = new Cart<Book>();
        cart2 += book1;
        cart2 += book2;
        cart2 += gift;
        
        Console.WriteLine($"2. {cart2}");
        
        for (int i = 0; i < cart2.Count; i++)
        {
            Console.WriteLine($"Товар {i+1}: {cart2[i]}");
        }
        
        var cart3 = new Cart<Book>();
        cart3.Add(ebook);
        
        Console.WriteLine($"3. {cart3}");
        
        var order1 = new Order<HomeShipping>(cart1)
        {
            Number = "1234567890",
            Delivery = new()
            {
                Address = new()
                {
                    Country = "Российская Федерация",
                    City = "Москва",
                    Street = "Ленина д.1 кв. 2",
                    State = "Московская область",
                    ZipCode = "123456"
                }
                ,Customer = new()
                {
                    Name = "Иван",
                    Email = "ivan@mail.ru",
                    Phone = "+79998887755"
                },DeliveryTime = new DateTime(2025,03,08),
                Courier = "СДЭК"
            }
        };
        
        var order2 = new Order<PickPointShipping>(cart2)
        {
            Number = "98767434",
            Delivery = new()
            {
                Address = new()
                {
                    Country = "Российская Федерация",
                    City = "Москва",
                    Street = "Красная Площадь д.1 кв. 1",
                    State = "Московская область",
                    ZipCode = "123456"
                }
                ,Customer = new()
                {
                    Name = "Владимир",
                    Email = "TheOne@mail.ru",
                    Phone = "+799977777777"
                },DeliveryTime = new DateTime(2025,03,08)
            }
        };

        var order3 = new Order<EmailShipping>(cart3)
        {
            Number = "2342342",
            Delivery = new EmailShipping()
            {
                Address = new()
                {
                    Email = "petr@mail.ru"
                },
                Customer = new()
                {
                    Name = "Петр",
                    Phone = "+79991234567"
                }
            }
        };
        
        order1.GetOrderDescription();
        order3.GetOrderDescription();
        
        Shop.PlaceOrder(order1);

    }
}