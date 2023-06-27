// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double [] FillArrayWithRandomNumber(int size)
{
    double[] arr = new double [size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0,100) + Math.Round(rnd.NextDouble(),2);
    }
    return arr;
}

System.Console.Write("Введите кол-во элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double [] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join("; ", array));

double max = array[0];
double min = array[0];

for (int i = 0; i < length; i++)
{
    if (array [i] > max)
    {
        max = array[i];
    }
    if (array [i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine($"Всего {length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

