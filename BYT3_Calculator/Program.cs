namespace BYT3_Calculator;

class Program
{
    static void Main(string[] args)
    {
        var add = new Calculator(1, 2, '+');
        var sub = new Calculator(3, 4, '-');
        var mul = new Calculator(5, 6, '*');
        var div = new Calculator(7, 8, '/');
        
        Console.WriteLine($"{add.Num1} {add.Operation} {add.Num2} = {add.Calculate()}");
        Console.WriteLine($"{sub.Num1} {sub.Operation} {sub.Num2} = {sub.Calculate()}");
        Console.WriteLine($"{mul.Num1} {mul.Operation} {mul.Num2} = {mul.Calculate()}");
        Console.WriteLine($"{div.Num1} {div.Operation} {div.Num2} = {div.Calculate()}");
    }
}