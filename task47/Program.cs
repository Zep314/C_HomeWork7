// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

using System;

const int size_w = 20;  // размер матрицы пусть будет таким
const int size_h = 10;

void init_matrix(double [,] local_matrix) //заполняем матрицу случайными числами
{
    Random rnd = new Random();
    for(int i=0;i<size_h;i++)
        for(int j=0;j<size_w;j++)
        {
            local_matrix[i,j] = rnd.NextDouble()*90+10; // диапазон от 10 до 100
        }
}

void print_matrix(double [,] local_matrix)  // красивая печать матрицы
{
    for(int i=0;i<size_h;i++)
    {
        Console.Write("[");  // каждую строку начинаем печатать с символа [
        for(int j=0;j<size_w-1;j++)
        {
            Console.Write($"{local_matrix[i,j]:f2} ");  // печатаем очередной элемент матрицы, с 2-мя знаками
                                                        // после запятой и пробелом после всего числа
        }
        Console.WriteLine($"{local_matrix[i,size_w-1]:f2}]"); //печатаем поcледний элемент в строке и символ ]
    }    
}

double [,] matrix = new double [size_h,size_w];
init_matrix(matrix);
print_matrix(matrix);

