namespace Module_7;

public class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public override string ToString()
    {
        return $"Покупатель {Name}, {Email}, {Phone}";
    }
}