// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами. 
//Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
Console.Clear();

string[] array = new string[] { "1234", "156", "-2", "computer science", "-2","Kazan", "2",":-)" };
//Создаем массив (строковый)

void PrintArray(string[] arr) //Функция печати массива/и преребирает весь массив 
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}


void Formation(string[] arr) // функия с условием/ если obect.Length <= 3 (объект меньше или равен 3) то 
{
    for (int i = 0; i < arr.Length; i++)
    {
        string obect = arr[i];
        if (obect.Length <= 3)
        {
            arr[i] = obect;
    }
        else arr[i] = string.Empty;
    }
}

PrintArray(array);
Formation(array);
