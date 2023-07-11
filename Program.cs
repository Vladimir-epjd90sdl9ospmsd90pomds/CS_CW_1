void ReadArray(string[] resArray)
{
    for (int i = 0; i < resArray.Length; i++)
    {
        Console.Write($"{resArray[i]} ");
    }
}


string[] resultArray = new string[] { "6", "дол", "9514", "12", "9fjh4" };

ReadArray(resultArray);