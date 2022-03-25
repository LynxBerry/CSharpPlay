class TestArray
{
    public static void TestMethod()
    {
        int[] nums = {2, 3, 4, 5, 6};
        ProcessArray(nums);
    }

    public static void ProcessArray(int[] nums)
    {
        var length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine($"The number is {nums[i]}");
        }
    }

    public static void ProcessArray2(int[5][] nums)
    {

    }
}