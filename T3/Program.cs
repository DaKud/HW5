// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.


void Print(double[] mass) 
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i]= Math.Round((new Random().Next(0,100))+ new Random().NextDouble(),2);
        Console.Write(mass[i] + " ");
    }
}

double[] mass = new double[5];
Print(mass);

double max = 0;
double min = 0;

for (int i = 0; i < mass.Length; i++)
{
    if(mass[i]>max)
    {
        max=mass[i];
    }
}
for (int i = 1; i < mass.Length; i++)
{
    if(mass[i]<mass[0])
    {
        min=mass[i];
    }
}

Console.WriteLine("Difference between MAX and MIN = "+ Math.Round((max-min),2));