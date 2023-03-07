// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

int resultSizeMax = 3;
Console.WriteLine("Введите строку: ");

string inputString = Console.ReadLine();
string[] convertibleArray = inputString.Split(' ', StringSplitOptions.RemoveEmptyEntries); 

Console.WriteLine("Изначальный массив: ");

for (int i = 0; i < convertibleArray.Length; i++)
{
    Console.Write(convertibleArray[i] + " ");
}
Console.WriteLine();

Console.WriteLine("Готовый массив (длинна не более 3 символа): ");

var resultArray = new string[convertibleArray.Length];  
var size = 0;
 

Console.Write($"[");
foreach (var value in convertibleArray)
{
if (value.Length <= resultSizeMax)
   {
    resultArray[size] = value;
    Console.Write($"{resultArray[size]}, ");
    size++;
   }
}
Console.Write($"]");