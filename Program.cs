public class Program
{

    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 4, 6, 7, 8, 23 };
        bool result = twoSomeValue(arr, 13);
        Console.WriteLine(result);
        Console.ReadKey();
    }

    public static bool twoSomeValue(int[] num, int target)
    {

        int left = 0;
        int right = num.Length - 1;

        while (left < right)
        {
            int curr = num[left] + num[right];

            if (curr == target)
                return true;

            if (curr > target)
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        return false;

    }

}