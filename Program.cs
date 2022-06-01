//Perfect Number Branch

int input = Int32.Parse(Console.ReadLine());

//Fill in the number checks

int SumOfALlNum = GetTheDivisor(input);

int GetTheDivisor(int userNumber)
{   
    int total = 0;

    for(int index = 1; index < userNumber; index++)
    {
        if (userNumber%index == 0)
        {
            total = total + index;
        }
    }

    return total;
}

if (SumOfALlNum == input)
{
    Console.WriteLine("Your number is perfect ", input);
} else
{
    Console.WriteLine("Your number is not perfect", input);
}

// In class solution
Console.WriteLine(isPerfectNumber(12)); // running the function independently

bool isPerfectNumber(int testVal)
{
    int runningTotal = 0;

    for (int i = testVal / 2; i > 0; i--)
    {
        if (testVal % i == 0)
        {
            runningTotal += i; // add and assign
        }
        if (testVal < runningTotal)
        {
            return false;
        }
    }

    return testVal == runningTotal;
}