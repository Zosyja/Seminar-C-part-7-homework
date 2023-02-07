// Написать программу, которая обменивает элементы первой строки и последней строки

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
int[,] ChangeRows(int[,]array){
    for (int j=0; j<array.GetLength(1); j++){
        int temp = array[0,j];
        array[0,j] = array[array.GetLength(0)-1,j];
        array[array.GetLength(0)-1,j] = temp;
    }
    return array;
}

int lenght = ReadInt("Введите количетсов строчек массива ");
int width = ReadInt("Введите количество столбцов массива: ");
int[,] matrix = FillArray(lenght, width);
Console.WriteLine("Исходный массив: ");
Printarray(matrix);
Console.WriteLine();

ChangeRows(matrix);
Console.WriteLine("Скорректированный массив: ");
Printarray(matrix);