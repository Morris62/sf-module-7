namespace Module_7;

public class Shipping<TAddress> where TAddress : Address
{
    public TAddress Address;
    public Customer Customer = new Customer();
}

public class HomeShipping : Shipping<ShippingAddress>
{
    public DateTime DeliveryTime { get; set; }
    public string Courier { get; set; }
    public new ShippingAddress Address;
}

public class PickPointShipping : Shipping<ShippingAddress>
{
    public DateTime DeliveryTime { get; set; }

    public new ShippingAddress Address;
}

public class EmailShipping : Shipping<EmailAddress>
{
    public new EmailAddress Address;
}