// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var nums = QuickSortAlg.GenerateArray();
QuickSortAlg.PrintArray(nums);
var p = QuickSortAlg.Partition(0, nums.Length - 1, nums);
QuickSortAlg.PrintArray(nums, p);
