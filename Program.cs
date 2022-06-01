int[] testValues = GetIntegersFromUser();
Console.WriteLine(FindDuplicateNumbers(testValues));


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


/* Important to define the method
 * This method uses a nested loop to iteratively compare all of the values in an array to each other.
 * If a match is found, that value is added to the duplicate numbers.
 * 
 */
int[] FindDuplicateNumbers(int[] numbers)
{
    int[] duplicateNumbers = new int[0]; //Empty array assign

    for (int outerIndex = 0; outerIndex < numbers.Length; outerIndex++)
    {
        for (int innerIndex = outerIndex + 1; innerIndex < numbers.Length; innerIndex++)
        {
            if (numbers[innerIndex] == numbers[outerIndex])
            {
                bool alreadyExist = false;

                for (int dupeIndex = 0; dupeIndex < duplicateNumbers.Length; dupeIndex++)
                {
                    if (duplicateNumbers[dupeIndex] == numbers[innerIndex])
                    {
                        alreadyExist = true;
                        dupeIndex = duplicateNumbers.Length;
                    }
                }
                if (!alreadyExist)
                {
                    //Console.WriteLine($"{innerIndex} matches {outerIndex}");//String interpolation
                    Array.Resize(ref duplicateNumbers, duplicateNumbers.Length + 1);
                    duplicateNumbers[duplicateNumbers.Length - 1] = numbers[innerIndex];
                    innerIndex = numbers.Length;
                }

            }
        }
    }

    return duplicateNumbers;
}