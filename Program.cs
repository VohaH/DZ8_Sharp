// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GetMatrix(int rows = 5, int columns = 5, int minValue = 1, int maxValue = 100)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = rand.Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write($"{matrix[i, l]}\t");
        }
        Console.WriteLine();
    }
}

int[,] ChangeMatrix(int[,] arr){
    int tmp;

    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1)-1; j++){
            for (int k = 0; k < arr.GetLength(1)-1; k++){
                if(arr[i,k] < arr[i,k+1]){
                    tmp = arr[i,k];
                    arr[i,k] =arr[i,k+1];
                    arr[i,k+1] = tmp;

                }
            }
        }
    }
    return arr;

}

int[,] matrix = GetMatrix();
PrintMatrix(matrix);
Console.WriteLine();
int[,] arr = ChangeMatrix(matrix);
PrintMatrix(arr);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void LookForMinSum(int[,]arr){

    int[] arr1 = new int[arr.GetLength(0)];
    int sum = 0;
    
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1)-1; j++){
            sum += arr[i,j];
        }
        arr1[i] = sum;
        sum = 0;
    }
    int ind = 0;
    int min = arr1[0];
    for (int k = 1; k < arr1.Length-1; k++)
    {
        
        if(min> arr1[k]){
            min = arr1[k];
            ind = k;
        }
    }
    Console.WriteLine($"Минимальный элемент находится на строке {ind+1}");

}

int[,] arryy = GetMatrix(5,3,1,10);
PrintMatrix(arryy);
Console.WriteLine();
LookForMinSum(arryy);


// Задача 60. ...Сформируйте трёхмерный массив . Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GetArray(int row = 2, int col = 2, int hig = 2, int minValue = 1, int maxValue = 10)
{
    int[,,] matrix = new int[row, col, hig];
    Random rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < hig; k++)
            {
                matrix[i,j,k] = rand.Next(minValue, maxValue);
            }
            
        }
    }
    return matrix;
}
void PrintArray(int[,,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i,j,k]}( {i},{j},{k})\t");
            }   
            Console.WriteLine();         
        }
        Console.WriteLine();
    }
}
 int[,,] array = GetArray();
 PrintArray(array);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] FillArray(int row, int col, int minValue, int maxValue){
    int[,] arr = new int[row,col];
    int startX = 0;
    int startY = 0;
    int finX = row - 1;
    int finY = col - 1;
    Random rand = new Random();

    while(startX <= finX && startY <= finY)
    {
        for (int i = startY; i <= finY; i++)   {
            arr[startX,i] = rand.Next(minValue, maxValue);
        }
        startX ++;
        for (int i = startX; i <= finX; i++)
        {
            arr[i,finY] = rand.Next(minValue, maxValue);
        }
        finY--;
        for (int i = finY; i >= startY; i--)
        {
            arr[finY,i] = rand.Next(minValue, maxValue);
        }
        finX--;
        for (int i = finX; i >= startX; i--)
        {
            arr[i,startY] = rand.Next(minValue, maxValue);
        }
        startY++;

    }
    return arr;
}

void PrintArr(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write($"{matrix[i, l]}\t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

int[,] arrray = FillArray(4, 4, 1, 10);
PrintArr(arrray);