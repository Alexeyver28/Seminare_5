// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// Console.WriteLine("Задайте размер массива:  ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[]numbers=new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("массив: ");
// PrintArray(numbers);
// int count = 0;

// for(int i=0; i<numbers.Length; i++)

// {
//     if (i % 2 == 0)
//     {
//         count += numbers[i];
//     }
// }
// Console.WriteLine($"Сумма элементов нечетных позиций = {count}");

// void FillArrayRandomNumbers(int [] array) 
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-i,+i);
//     }
// }

// void PrintArray(int[] array) 
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
  
// }

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end);
    }
    return RandomArray;
}
    void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int[] tripleArray = CreateRandomArray(4,100, 1000);
int ruslt = 0;
    for(int i=0; i < tripleArray.Length; i++ )
    {
      if (i % 2 != 0) 
        {
        ruslt += tripleArray[i];
        }
    }
ShowArray(tripleArray);
Console.WriteLine(ruslt);
