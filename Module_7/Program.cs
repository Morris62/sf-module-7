namespace Module_7;

class Program
{
    class A
    {
        public virtual void Display()
        {
            Console.Write("A");
        }
    }

    class B : A
    {
        public new void Display()
        {
            Console.Write("B");
        }
    }

    class C : A
    {
        public override void Display()
        {
            Console.Write("C");
        }
    }

    class D : B
    {
        public new void Display()
        {
            Console.Write("D");
        }
    }

    class E : C
    {
        public new void Display()
        {
            Console.Write("E");
        }
    }
    
    static void Main(string[] args)
    {
        D d = new D();
        E e = new E();
        
        d.Display();
        ((A)e).Display();
        ((B)d).Display();
        ((A)d).Display();
    }
}