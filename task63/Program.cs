Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintNums(int maxNum, int currentNum = 1)
{
    if(currentNum <= maxNum)
    {
        string symbol = ", ";
        if(currentNum == maxNum)
        {
            symbol = ".";
        }
        Console.Write(currentNum + symbol);
        currentNum++;
        PrintNums(maxNum, currentNum);
    }
}

PrintNums(n);