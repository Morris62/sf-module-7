namespace Module_7;

public class Order<TShipping>
{
    public TShipping Delivery { get; set; }
    public string Number { get; set; }
    public Cart<Book> Cart { get; private set; }

    public Order(Cart<Book> cart)
    {
        Cart = cart;
    }
}