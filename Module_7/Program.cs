namespace Module_7;

class Program
{
    class Employee(string name, int age, int salary)
    {
        public string Name = name;
        public int Age = age;
        public int Salary = salary;

        public override string ToString()
        {
            return $"{Name} {Age} {Salary}";
        }
    }

    class ProjectManager(string name, int age, int salary, string projectName) : Employee(name, age, salary)
    {
        public string ProjectName = projectName;

        public override string ToString()
        {
            return $"{base.ToString()} {ProjectName}";
        }
    }

    class Developer(string name, int age, int salary, string programminlanguale) : Employee(name, age, salary)
    {
        public string ProgrammingLanguage = programminlanguale;

        public override string ToString()
        {
            return $"{base.ToString()} {ProgrammingLanguage}";
        }
    }
    
    static void Main(string[] args)
    {
        var emp = new Employee("John", 30, 10000);
        var dev = new Developer("Andrew", 25, 15000, "C#");
        var proj = new ProjectManager("Max",33,20000,"Architect");
        
        Console.WriteLine(emp);
        Console.WriteLine(dev);
        Console.WriteLine(proj);
    }
}