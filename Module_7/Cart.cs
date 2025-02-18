namespace Module_7;

public class Cart<TBook> where TBook: Book
{
    private TBook?[] _books = new TBook?[10];
    private int _index = 0;
    
    public int Count => _index;

    private bool IsEmpty => !_books?.Any() ?? true;
    
    public float TotalPrice
    {
        get
        {
            var totalPrice = 0.0f;
            foreach (var book in _books)
            {
                totalPrice += book?.GetFullPrice() ?? 0.0f;
            }
            return totalPrice;
        }
    }
    
    public static Cart<TBook> operator + (Cart<TBook> cart, TBook? product)
    {
        var newCart = cart;
        newCart.Add(product);
        return newCart;
    }

    public void Add(TBook? product)
    {
       _books[_index++] = product;
    }
    
    public TBook? this[int index]
    {
        get
        {
            if (index < 0 || index >= _books.Length)
            {
                return null;
            }
            return _books[index];
        }
        set
        {
            if (index >= 0 && index < Count)
            {
                _books[index] = value;
            }
        }
    }
    
    public override string ToString()
    {
        if (IsEmpty)
            return "$Корзина пуста";
        
        return $"В корзине {Count} товаров на сумму {TotalPrice:F2}";
    }
}