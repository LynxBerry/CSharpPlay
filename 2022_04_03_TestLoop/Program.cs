// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int i;
for (i = 0; i < 10; i++)
{
    Console.WriteLine($"num in loop: {i}");
    if (i == 9) // It will never be reached.
    {
        Console.WriteLine("Hit break"); 
        break;
    }
} // At the end of each loop, i will increment.

Console.WriteLine($"num outside loop: {i}");

int j = 0;

while(j < 10)
{
    Console.WriteLine($"num j in loop: {j}");
    if (j == 9)
    {
        Console.WriteLine("j hit break");
        break;
    }
    j++;


}

Console.WriteLine($"num j outside loop: {j}");
