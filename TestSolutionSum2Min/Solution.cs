public class Solution()
{
    public int SumOfTwoMinNumbers(int[] values)
    {
        if (values == null)
            throw new NullReferenceException("коллекция равна null");
        if (values.Length < 2)
            throw new ArgumentOutOfRangeException("values", "меньше двух элементов в коллекции");

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
        return min1 + min2;
    }
}