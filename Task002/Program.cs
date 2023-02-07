// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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
int[,] ArrangeArray(int[,]array){
     for (int i=0; i<array.GetLength(0); i++){
        for (int j=0; j<array.GetLength(1)-1; j++){
            for (int k=j+1; k<array.GetLength(1); k++){
                if (array[i,k] > array[i,j]){
                    int temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }                   
            }
        };
    }
    return array;
}

int lenght = ReadInt("Введите количество строчек массива ");
int width = ReadInt("Введите количество столбцов массива: ");
int[,] matrix = FillArray(lenght, width);
Console.WriteLine("Исходный массив: ");
Printarray(matrix);
Console.WriteLine();

ArrangeArray(matrix);
Console.WriteLine("Скорректированный массив: ");
Printarray(matrix);