// Function to get all duplicate numbers and store it to new array
//int[] intArray = new int[] { 1, 2, 3, 4, 2, 1, 4, 5, 2, 1, };
//int[] myDuplicateNum = GetDuplicate(intArray);

//int[] GetDuplicate(int[] myArray)
//{
//    int[] duplicates = new int[myArray.Length];
//    int counter = 1;

//    for (int index = 0; index < myArray.Length; index++)
//    {
//        if (myArray[index] == myArray[counter])
//        {
//            duplicates[index] = myArray[index];
//            counter++;
//        }
//        else if (myArray[index] == duplicates[index])
//        {
//            duplicates[index] = myArray[index];
//        }
//    }

//    return duplicates;
//}

//Console.WriteLine(String.Join(' ', myDuplicateNum));

// IN CLASS SOl.
// Start with function first
// To run all elements in array comparing each
FindDuplicateNumbers(new int[] { 1,2,2,3,4,3,2,7 });

int[] FindDuplicateNumbers(int[] numbers)
{
    int[] duplicateNumbers = new int[0]; //Empty array assign

    for(int outerIndex = 0; outerIndex < numbers.Length; outerIndex++)
    {
        for (int innerIndex = outerIndex + 1 ; innerIndex < numbers.Length; innerIndex++)
        {
            if(numbers[innerIndex] == numbers[outerIndex])
            {
                bool alreadyExist = false;

                for (int dupeIndex = 0; dupeIndex < duplicateNumbers.Length; dupeIndex++)
                {
                    if(duplicateNumbers[dupeIndex] == numbers[innerIndex])
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