namespace Module_7;

class Program
{
    class Book
    {
        public required string  Title { get; set; }
        public required string Author { get; set; }
    }

    class BookCollection(Book?[] collection)
    {
        private Book?[] _collection = collection;

        public int Length => _collection.Length;

        public Book? this[int index]
        {
            get
            {
                if (index >= 0 && index < _collection.Length)
                {
                    return _collection[index];
                }
                else
                {
                    return null;
                }
            }
            private set
            {
                if (index >= 0 && index < _collection.Length)
                {
                    _collection[index] = value;
                }
            }
        }

        public Book? this[string title]
        {
            get
            {
                foreach (var book in _collection)
                {
                    if (book?.Title == title)
                    {
                        return book;
                    }
                }

                return null;
            }
        }
    }

    static void Main()
    {
        Book[] array =
        [
            new Book { Title = "The Hobbit", Author = "Tolkien" },
            new Book { Title = "The Lord of the Rings", Author = "Tolkien" },
            new Book { Title = "The Hitchhiker's Guide to the Galaxy", Author = "Adams" },
            new Book { Title = "Happy English", Author = "Teacher" }
        ];

        var collection = new BookCollection(array);

        for (var i = 0; i < collection.Length; i++)
        {
            Console.WriteLine($"Book{i + 1}: {collection[i]?.Title} by {collection[i]?.Author}");
        }

        Console.WriteLine($"Author of The Hobbit: {collection["The Hobbit"]?.Author}");
    }
}