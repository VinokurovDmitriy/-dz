Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintNums(int currentNum, int max)
{
    if(currentNum <= max)
    {
        string symbol = ", ";
        if(currentNum == max)
        {
            symbol = ".";
        }
        Console.Write(currentNum + symbol);
        currentNum++;
        PrintNums(currentNum, max);
    }
}
PrintNums(m, n);