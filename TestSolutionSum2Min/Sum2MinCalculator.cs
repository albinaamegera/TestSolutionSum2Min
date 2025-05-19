public class Sum2MinCalculator()
{
    public int SumOfTwoMinNumbers(IEnumerable<int>? values)
    {
        if (values == null)
            throw new NullReferenceException("коллекция равна null");
        if (values.Count() < 2)
            throw new ArgumentOutOfRangeException(nameof(values), "меньше двух элементов в коллекции");

        int result;
        int min1 = int.MaxValue;
        int min2 = int.MaxValue;

        foreach (var num in values)
        {
            if (num < min1)
            {
                min2 = min1;
                min1 = num;
                
            }
            else if (num < min2)
            {
                min2 = num;
            }
        }
        
        checked
        {
            result = min1 + min2;
        }

        return result;
    }
}