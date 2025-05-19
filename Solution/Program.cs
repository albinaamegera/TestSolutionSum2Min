public class Program
{
    public static void Main(string[] args)
    {
        // пример

        Sum2MinCalculator _calculator = new();

        int[] intValues = { 4, 0, 3, 19, 492, -10, 1 };

        Console.WriteLine(_calculator.SumOfTwoMinNumbers(intValues));
        Console.ReadLine();
    }
    

}