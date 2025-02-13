using System.Data;

namespace Module_7;
    
class Program
{
    class Record<T1, T2>
    {
        public T1 Id;
        public T2 Value;
        public DateTime Date;
    }
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp =a;
        a = b;
        b = temp;
    }
    class Obj
    {
        public void Display<T>(T obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
    static void Main()
    {
        var record = new Record<int, string>
        {
            Id = 1,
            Value = "MyAlbum",
            Date = DateTime.Now
        };
        
        Console.WriteLine($"record.Id: {record.Id}");
        Console.WriteLine($"record.Value: {record.Value}");
        Console.WriteLine($"record.Date: {record.Date}");
        
        var obj = new Obj();
        obj.Display(345);
        obj.Display(3.45);
        
        var a = 10;
        var b = 20;
        Swap(ref a, ref b);
        Console.WriteLine($"a: {a}, b: {b}");

    }
}