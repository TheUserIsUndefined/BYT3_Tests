using BYT3_Calculator.Exceptions;

namespace BYT3_Calculator;

public class Calculator(double num1, double num2, char operation)
{
    public double Num1 { get; set; } = num1;
    public double Num2 { get; set; } = num2;
    public char Operation { get; set; } = operation;

    public double Calculate()
    {
        var result = Operation switch
        {
            '+' => Num1 + Num2,
            '-' => Num1 - Num2,
            '*' => Num1 * Num2,
            '/' => Num2 == 0 ? throw new DivideByZeroException() : Num1 / Num2,
            _ => throw new UnknownOperationException()
        };
        
        if (double.IsInfinity(result))
            throw new BoundariesExceededException(result.GetType().Name);
        
        return result;
    }
}