// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2

int[] MyArray = new int[10];
for (int i = 0; i < MyArray.Length; i++)
{
    MyArray[i] = new Random().Next(100, 1000);
    Console.Write(MyArray[i] + " ");  
}
Console.WriteLine();

int count = 0;

for (int i = 0; i < MyArray.Length; i++)
{
    if ( MyArray[i] % 2 == 0 )
    {
        count++;
    }
}

Console.WriteLine("Even numbers quantity: " + count );
