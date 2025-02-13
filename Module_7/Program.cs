namespace Module_7;
static class IntExtention
    {
     public static int GetNegative(this int number)
     {
         return number > 0 ? number * -1 : number;
     }
     public static int GetPositive(this int number)
     {
         return number < 0 ? number * -1 : number;
     }
    }
    
class Program
{
    static void Main()
    {
        int num1 = 8;
        int num2 = -1;
        int num3 = 0;
        
        Console.WriteLine($"num1 = {num1}");
        Console.WriteLine($"num2 = {num2}");
        Console.WriteLine($"num3 = {num3}");
        
        Console.WriteLine($"num1.GetNegative() = {num1.GetNegative()}");
        Console.WriteLine($"num2.GetNegative() = {num2.GetNegative()}");
        Console.WriteLine($"num3.GetNegative() = {num3.GetNegative()}");

        Console.WriteLine($"num1.GetPositive() = {num1.GetPositive()}");
        Console.WriteLine($"num2.GetPositive() = {num2.GetPositive()}");
        Console.WriteLine($"num3.GetPositive() = {num3.GetPositive()}");
    }
}