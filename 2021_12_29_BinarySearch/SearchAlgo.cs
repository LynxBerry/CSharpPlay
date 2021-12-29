class SearchAlgo 
{
    public int BinarySearch(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        int mid;
        while (left <= right)
        {
            mid = left + ((right - left) >> 1);

            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else if (nums[mid] > target)
            {
                right = mid - 1;
            }

        }

        return -1;
    }
}