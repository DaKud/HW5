


// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



    int[] MyArray = new int[10];

for (int i = 0; i < MyArray.Length; i++)
{
    MyArray[i] = new Random().Next(0, 20);
    Console.Write(MyArray[i] + " ");  
}
Console.WriteLine();

int sum =0;
for (int i = 0; i < MyArray.Length; i++)
{
    if (i % 2 !=0) 
    {
        sum += MyArray[i];
    }
}
Console.WriteLine("odd position numbers sum: {0}", sum );

