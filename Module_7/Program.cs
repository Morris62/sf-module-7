namespace Module_7;

class Program
{
    abstract class Person(string name)
    {
        protected readonly string Name = name;
        public abstract void Display();
    }

    class Employee(string name, bool isOnShift) : Person(name)
    {
        public override void Display()
        {
            Console.WriteLine($"Name: {Name}, IsOnShift: {isOnShift}");
        }
    }

    class Guest(string name, DateTime arrivalTime) : Person(name)
    {
        public override void Display()
        {
            Console.WriteLine($"Name: {Name}, ArrivalTime: {arrivalTime}");
        }
    }
    static void Main()
    {
        var employee = new Employee("John", true);
        var guest = new Guest("Jane", DateTime.Now);
        employee.Display();
        guest.Display();
        
        Person person = employee;
        person.Display();
    }
}