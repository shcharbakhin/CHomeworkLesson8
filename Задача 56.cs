//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
{
    Random rand = new Random();
    int m = rand.Next(2, 10);
    Console.WriteLine($"количество строк: {m}");
    int n = rand.Next(2, 10);
    Console.WriteLine($"количество столбцов: {n}");
    int[,] array = new int[m, n];
    int i;
    int j;
    int sum;
    int min = 100;
    int minstring=0;
    //значение максиамально возможной суммы элементов массива исходя из размера рандома
    string[] find = new string[n];
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        {
            array[i, j] = rand.Next(1, 10);
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Сумма всех элементов каждой строки:");
    for (i = 0; i < m; i++)
    {
        sum = 0;
        for (j = 0; j < n; j++)
        {
            sum = sum + array[i, j];
        }
        Console.WriteLine(sum);
        find[i] = Convert.ToString(sum);
        if (sum < min)
        {
            min = sum;
            minstring = i+1;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов в строке {minstring}");
}