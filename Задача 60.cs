{
    Random rand = new Random();
    string[,,] array = new string[2, 2, 2];
    string[] uniq = new string[8];
    // массив для проверки (величина = умножение длины, ширины и высоты массива
    for (int x = 0; x < 2; x++)
    {
        for (int y = 0; y < 2; y++)
        {
            for (int z = 0; z < 2; z++)
            {
                string num = Convert.ToString(rand.Next(10, 99));
                int index = System.Array.IndexOf(uniq, num);//ищу строку в массиве
                if (index < 0)
                    if (index < 0)
                    {
                        array[x, y, z] = num;
                        Console.Write(array[x, y, z]);
                        Console.Write($"({x},{y},{z}); ");
                    }
                    else
                    {
                        z--;
                    }
                Console.WriteLine();
            }
        }
    }
}