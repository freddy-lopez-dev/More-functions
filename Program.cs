// Function to get all duplicate numbers and store it to new array
int[] intArray = new int[] { 1, 2, 3, 4, 2, 1, 4, 5, 2, 1, };
int[] myDuplicateNum = GetDuplicate(intArray);

int[] GetDuplicate(int[] myArray)
{
    int[] duplicates = new int[myArray.Length];
    int counter = 1;

    for (int index = 0; index < myArray.Length; index++)
    {
        if (myArray[index] == myArray[counter])
        {
            duplicates[index] = myArray[index];
            counter++;
        }
        else if (myArray[index] == duplicates[index])
        {
            duplicates[index] = myArray[index];
        }
    }

    return duplicates;
}

Console.WriteLine(String.Join(' ', myDuplicateNum));