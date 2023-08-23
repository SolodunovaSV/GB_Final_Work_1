/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

int CalcSizeArray(string[] strArray)
{
    int size = 0;
    for(int i = 0; i < strArray.Length; i++)
    {
        if(strArray[i].Length <= 3)
        {
            size++;
        }
    }
    return size;
}

string[] CreateArray(string[] strArray)
{
    int size = CalcSizeArray(strArray);
    string[] resultArray = new string[size];
    int index = 0;

    for(int i = 0; i < strArray.Length; i++)
    {
        if(strArray[i].Length <= 3)
        {
            resultArray[index] = strArray[i];
            index++;
        }
    }
    return resultArray;
}

void PrintArray(string[] strArray)
{
    Console.Write("[");
    for(int i = 0; i < strArray.Length; i++)
    {
        Console.Write(strArray[i]);
        if(i < strArray.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");
}

string[] strArray = {"Hello", "2", "world", ":-)"};
string[] result = CreateArray(strArray);
PrintArray(result);