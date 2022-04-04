// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

using System;


const int size_w = 10;  // размер матрицы пусть будет таким
const int size_h = 7;

void init_matrix(int [,] local_matrix) //заполняем матрицу случайными числами
{
    Random rnd = new Random();
    for(int i=0;i<size_h;i++)
        for(int j=0;j<size_w;j++)
        {
            local_matrix[i,j] = rnd.Next(-9,10); // диапазон от 10 до 100
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

void print_array(double [] local_array)  // красивая печать одномерного массива
{
  Console.Write("[");
  for(int i=0;i<local_array.Length - 1;i++)
  {
      Console.Write($"{local_array[i]:f2}; ");
  }
  Console.WriteLine($"{local_array[local_array.Length - 1 ]:f2}]");
}

double [] GetAve(int [,] local_matrix)  // считаем среднее значение элементов столбцов в матрице
{
    double [] ret = new double [size_w];
    for(int j=0;j<size_w;j++) // двигаемся сначала по строке
    {
        ret[j] = 0;
        for(int i = 0;i<size_h;i++) // а тут пробегаемся по столбцу
            ret[j] += local_matrix[i,j];
        ret[j] /= size_h;    
    }
    return ret;
}

int [,] matrix = new int [size_h,size_w];  // объявление матрицы
init_matrix(matrix);
print_matrix(matrix);
double [] ave = GetAve(matrix);  // объявление массива и расчет в него среднего по столбцам матрицы
Console.WriteLine();
print_array(ave);
