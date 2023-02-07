// В прямоугольной матрице найти строку с наименьшей суммой элементов.

int ReadInt(string message){
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int[,] FillArray(int lenght, int width){
    Random random = new Random();
    int[,] array = new int[lenght, width];
    for (int i=0; i<array.GetLength(0); i++)
        for (int j=0; j<array.GetLength(1); j++)
            array[i,j] = random.Next(0,10);
    return array;
}
void Printarray(int[,] array){
    for (int i=0; i<array.GetLength(0); i++){
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write($"{array[i,j]} ");
        Console.WriteLine();
    }
}
void RowWithMinSumElements(int[,]array){
    int[] sum = new int[array.GetLength(0)];
    for (int i=0; i<array.GetLength(0); i++){
        int summa = 0;
        for (int j=0; j<array.GetLength(1); j++){
            summa = summa + array[i,j];
        }
    sum[i] = summa;
    }
    int minimum = sum[0];
    int index = 0;
    for(int i=0; i<array.GetLength(0);i++){
        if(sum[i]<minimum){
            minimum = sum[i];
            index = i;
        }
    }
Console.WriteLine($"Строка {index+1} содержит наименьшую сумму элементов = {minimum}.");
}

int lenght = ReadInt("Введите количество строчек массива ");
int width = ReadInt("Введите количество столбцов массива: ");
int[,] matrix = FillArray(lenght, width);
Console.WriteLine("Исходный массив: ");
Printarray(matrix);
Console.WriteLine();

RowWithMinSumElements(matrix);