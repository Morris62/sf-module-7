namespace Module_7;

public abstract class Address
{
    
}

public class ShippingAddress : Address
{
    public required string Country { get; set; }
    public required string State { get; set; }
    public required string City { get; set; }
    public required string Street { get; set; }
    public required string ZipCode { get; set; }

    public override string ToString()
    {
        return $"Адрес: {Country}, {State}, {City}, {Street}, {ZipCode}";
    }
}

public class EmailAddress : Address
{
    public required string Email { get; set; }

    public override string ToString()
    {
        return $"email: {Email}";
    }
}