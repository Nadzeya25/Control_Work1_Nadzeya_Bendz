/* Написать программу, которая из имеющегося массива строк формирует массив из строк,
 длина которых меньше либо равна 3 символа */
string[] array1 = { "Hello","*~~", "LO", "world", "VE", "~~*" };
int size2 = 0;
int num = 3;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= num)
    {
        size2++;
    }
}
string[] array2 = new string[size2];
void SelectStringPrint(string[] box)
{
    for (int index = 0; index < array1.Length; index++)
    {
        if (array1[index].Length <= num)
        {
            Console.Write($"{array1[index]}");
        }
    }
}
Console.WriteLine();
Console.Write("[");
SelectStringPrint(array2);
Console.Write("]");



