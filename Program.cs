void ReadArray(string[] readingArray)
{
    for (int i = 0; i < readingArray.Length; i++)
    {
        Console.Write($"{readingArray[i]} ");
    }
}

void FilterArray(string[] workArray, string[] resArray)
{
    int j = 0;
    for (int i = 0; i < workArray.Length; i++)
    {
        if (workArray[i].Length <= 3)
        {
            resArray[j] = workArray[i];
            j++;
        }
    }
}


string[] startArray = new string[] { "6", "дол", "9514", "12", "Jotf", "2A", "9Hgf4" };
string[] resultArray = new string[startArray.Length];

FilterArray(startArray, resultArray);
ReadArray(resultArray);