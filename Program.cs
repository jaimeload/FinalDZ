string[] array1 = new string[4] {"Hello, World!", "=)", "24.01.2023", "Hi!"};
string[] array2 = new string[array1.Length];

FillArray2(array1, array2);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);


void FillArray2(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}   ");
    }
}