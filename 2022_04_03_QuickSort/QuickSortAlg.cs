class QuickSortAlg
{
    static Random rand = new Random();

    public static int[] GenerateArray()
    {
        int[] nums = new int[100];
        for (int i = 0; i < 100; i++)
        {
            nums[i] = rand.Next(101);
        }

        return nums;
    }
    public static void PrintArray(int[] nums) => Console.WriteLine($"[{string.Join(',', nums)}]");

    public static void PrintArray(int[] nums, int pivotPos)
    {
        Console.Write("[");
        for (int i = 0; i < pivotPos; i++)
        {
            if (i == pivotPos - 1)
                Console.WriteLine($"{nums[i]}]");
            Console.Write($"{nums[i]},");
            
        }

        Console.WriteLine($"Pivot Postion: {pivotPos}; Pivot Value: {nums[pivotPos]}");
        Console.Write("[");
        for (int i = pivotPos + 1; i < nums.Length; i++)
        {
            if (i == nums.Length - 1)
                Console.WriteLine($"{nums[i]}]");
            Console.Write($"{nums[i]},");
        }

    }

    public static int Partition(int lo, int hi, int[] nums)
    {
        int pivotPos = rand.Next(lo, hi + 1);
        int pivotValue = nums[pivotPos];

        Swap(lo, pivotPos, nums);

        int i = lo + 1;
        int j = hi;

        while (i <= j)
        {
            while (i < hi + 1)
            {
                if (nums[i] > pivotValue)
                    break;
                i++;
            }

            while (j > lo)
            {
                if (nums[j] < pivotValue)
                    break;
                j--;
            }

            if (i >= j) // i crosses j
                break;

            Swap(i, j, nums);

        } // At the end, j should be the place of small number

        Swap(lo, j, nums);

        return j;

    }

    private static void Swap(int i, int j, int[] nums)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}