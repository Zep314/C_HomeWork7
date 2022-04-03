// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса 
// нечётные, и замените эти элементы на их квадраты.

using System;

const int size_w = 10;  // размер матрицы пусть будет таким
const int size_h = 7;

void init_matrix(int [,] local_matrix) //заполняем матрицу случайными числами
{
    Random rnd = new Random();
    for(int i=0;i<size_h;i++)
        for(int j=0;j<size_w;j++)
        {
            local_matrix[i,j] = rnd.Next(-99,100); // диапазон от 10 до 100
        }
}

void print_matrix(int [,] local_matrix)  // красивая печать матрицы
{
    for(int i=0;i<size_h;i++)
    {
        Console.Write("[");  // каждую строку начинаем печатать с символа [
        for(int j=0;j<size_w-1;j++)
        {
            Console.Write($"{local_matrix[i,j],5},");  // печатаем очередной элемент матрицы
                                                       // и запятую после него, разделенные табуляцией
        }
        Console.WriteLine($"{local_matrix[i,size_w-1],5}]"); //печатаем поcледний элемент в строке и символ ]
    }    
}

int [,] matrix = new int [size_h,size_w];  // объявляем массив

void process_matrix()  // модифицируем матрицу
{
    for(int i=0;i<size_h;i++)
        for(int j=0;j<size_w;j++)
            if (( i % 2 != 0 )&&( j % 2 != 0 )) matrix[i,j]=matrix[i,j]*matrix[i,j];
}

init_matrix(matrix);
print_matrix(matrix);
process_matrix();
Console.WriteLine();  // печатаем пустую строку, чтобы разделить матрицу до и после обработки
print_matrix(matrix);
