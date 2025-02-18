namespace Module_7;

public abstract class Book(string isbn, string author, string title, float price)
{
    private float _price = price;
    private string ISBN { get; set; } = isbn;
    private string Author { get; set; } = author;
    private string Title { get; set; } = title;
    public virtual float Price
        {
            get => _price;
            protected set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Стоимость товара должна быть положительной!");
                }
                else
                {
                    _price = value;
                }
            }
        }
    protected abstract float GetDiscount();
    public virtual float GetFullPrice() => _price - GetDiscount();
    public override string ToString() => $"{Title} - {Author} - {Price:C2}";
}

class DigitalBook(string isbn, string author,string title, float price, string downloadLink) : Book(isbn, author, title, price)
{
    public string DownloadLink { get; set; } = downloadLink;
    protected override float GetDiscount()
    {
        return Price * 0.1f;
    }
}

class PaperBook(string isbn, string author,string title, float price, float weight) : Book(isbn, author, title, price)
{
    protected float Weight { get; set; } = weight;

    protected override float GetDiscount()
    {
        if (Price > 1000)
        {
            return Price * 0.05f;
        }

        return 0.0f;
    }
}

class GiftBook(string isbn, string author, string title) : Book(isbn, author, title, 0.0f)
{
    public override float Price => 0.0f;
    protected override float GetDiscount()
    {
        return 0.0f;
    }
    
    public override float GetFullPrice() => 0.0f;
}