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
