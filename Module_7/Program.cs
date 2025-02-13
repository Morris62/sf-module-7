namespace Module_7;

class Program
{
    class Vector
    {
        public int X;
        public int Y;

        public static Vector operator + (Vector v1, Vector v2)
        {
            return new Vector
            {
                X = v1.X + v2.X,
                Y = v1.Y + v2.Y
            };
        }

        public static Vector operator + (Vector v)
        {
            return new Vector
            {
                X = v.X,
                Y = v.Y
            };
        }

        public static Vector operator +(Vector v1, (int x, int y) v2)
        {
            return new Vector
            {
                X = v1.X + v2.x,
                Y = v1.Y + v2.y
            };
        }

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }
    }
    
    static void Main(string[] args)
    {
        var a = new Vector {X = 1, Y = 2};
        var b = new Vector {X = 3, Y = 4};
        Console.WriteLine($"a: {a}");
        Console.WriteLine($"b: {b}");
                
        var c = a + b;
        Console.WriteLine($"c: {c}");
        
        var d = +a;
        Console.WriteLine($"d: {d}");
        
        var e = a + (1, 2);
        Console.WriteLine($"e: {e}");
    }
}