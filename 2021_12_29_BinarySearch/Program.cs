// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var searchAlgo = new SearchAlgo();
int pos = searchAlgo.BinarySearch(new int[]{2,3,5,8}, 9);
Console.WriteLine(pos);