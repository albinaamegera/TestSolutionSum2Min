public class Program
{
    public static void Main(string[] args)
    {
        // пример

        Solution solution = new();

        int[] intValues = { 4, 0, 3, 19, 492, -10, 1 };

        Console.WriteLine(solution.SumOfTwoMinNumbers(intValues));
        Console.ReadLine();
    }
    

}