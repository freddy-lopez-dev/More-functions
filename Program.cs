int[] testValues = GetIntegersFromUser();


int[] GetIntegersFromUser()
{
    int[] numbers = new int[0];

    Console.WriteLine("Enter a number, or q to stop");

    string inputString = Console.ReadLine();

    while(inputString != "q")
    {
        Array.Resize(ref numbers, numbers.Length + 1);
        numbers[numbers.Length - 1] = int.Parse(inputString);
        inputString = Console.ReadLine();
    }

    return numbers;
}