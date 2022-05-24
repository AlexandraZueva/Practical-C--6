//Найти произведение двух матриц

void FillArray (int [,]matr, int[,] matr1)
{
    for (int a = 0; a < matr.GetLength(0); a++)
    {
        for (int b = 0; b < matr.GetLength(1); b++)
        {
            matr[a, b] = new Random().Next(1, 10);
        }
    }
    for (int a = 0; a < matr1.GetLength(0); a++)
    {
        for (int b = 0; b < matr1.GetLength(1); b++)
        {
            matr1[a, b] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr, int[,] matr1)
{
    for (int a = 0; a < matr.GetLength(0); a++)
    {
        for (int b = 0; b < matr.GetLength(1); b++)
        {
            Console.Write($"{matr[a, b]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int a = 0; a < matr1.GetLength(0); a++)
    {
        for (int b = 0; b < matr1.GetLength(1); b++)
        {
            Console.Write($"{matr1[a, b]} ");
        }
        Console.WriteLine();
    }
}

void Multiplicator(int[,] matr, int[,] matr1, int[,] multiMatr)
{
    for (int a = 0; a < matr.GetLength(0); a++)
    {
        for (int b = 0; b < matr.GetLength(1); b++)
        {
            multiMatr[a, b] = matr[a, b] * matr1[a, b];
        }
    }
}

void PrintCompositionArray(int[,] multiMatr)
{
    for (int a = 0; a < multiMatr.GetLength(0); a++)
    {
        for (int b = 0; b < multiMatr.GetLength(1); b++)
        {
            Console.Write($"{multiMatr[a, b]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[2, 2];
int[,] matrix1 = new int[2, 2];
int[,] multiMatrix = new int[2, 2];
FillArray(matrix, matrix1);
PrintArray(matrix, matrix1);
Console.WriteLine();
Multiplicator(matrix, matrix1, multiMatrix);
PrintCompositionArray(multiMatrix);