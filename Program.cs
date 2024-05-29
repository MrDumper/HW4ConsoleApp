Console.WriteLine("Введите n и m матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int m  = Convert.ToInt32(Console.ReadLine());

Random random = new Random();

int sum = 0;

int[,] matrixA = new int[n, m];
int[,] matrixB = new int[n, m];
int[,] matrixAB = new int[n, m]; // далее в коде, в комментариях будет показано, как обойтись 2-мя матрицами

Console.WriteLine("Матрица А: ");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrixA[i, j] = random.Next(1, 10);
        matrixB[i, j] = random.Next(1, 10);
        sum += matrixA[i, j];
        matrixAB[i, j] = matrixA[i, j] + matrixB[i, j];
        Console.Write($"{matrixA[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine($"Сумма элементов матрицы A равна: {sum}");
Console.WriteLine("Матрица B: ");

for (int i = 0; i < n; i++)
{
    for(int j = 0; j<m; j++)
    {
        Console.Write($"{matrixB[i, j]} ");
        // matrixB[i, j] = matrixB[i, j] + matrixA[i, j]; - это вариант кода, где я могу обойтись 2-мя матрицами вместо 3-х
    }
    Console.WriteLine();
}

Console.WriteLine("Матрица полученная сложением матриц: ");

for (int i = 0; i < n; i++)
{
    for( int j = 0; j < m; j++)
    {
        Console.Write($"{matrixAB[i ,j], 3} ");
        // Console.Write($"{matrixB} "); // см. коммент выше
    }
    Console.WriteLine();
}

Console.ReadKey();