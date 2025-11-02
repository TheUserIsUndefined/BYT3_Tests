namespace BYT3_Calculator.Exceptions;

public class BoundariesExceededException(string varType) : Exception($"{varType} boundaries are exceeded.");