using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //Задание 1
        //    //int[] omas = { 10, 21, 1, 2, 3 };
        //    //Console.WriteLine($"размер:{omas.Length}");
        //    //string[] mas = { "Антон", "Даня", "Никита" };
        //    //int size = mas.Length;
        //    //Console.WriteLine($"Размер:{size}");
        //    //Console.ReadLine();


        //    //Задание 2

        //}
        //static int size()
        //{
        //    Console.WriteLine("Введите размер одномерного массива:");
        //    int size;
        //    while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
        //    {
        //        Console.WriteLine("Ошибка! Введите положительное число.");
        //    }
        //    return size;
        //}

        //// Метод для ввода значений в массив
        //static int[] Input(int size)
        //{
        //    int[] omas = new int[size];
        //    for (int i = 0; i < omas.Length; i++)
        //    {
        //        Console.WriteLine($"Введите {i + 1} элемент массива:");
        //        omas[i] = int.Parse(Console.ReadLine());
        //    }
        //    return omas;
        //}

        //// Метод для вывода элементов массива
        //static void Output(int[] omas)
        //{
        //    Console.WriteLine("Элементы массива:");
        //    foreach (var el in omas)
        //    {
        //        Console.WriteLine(el);
        //    }
        //}

        //static void Main()
        //{
        //    int arraySize = size();          
        //    int[] omas = Input(arraySize);   
        //    Array.Clear(omas, 1, 2);
        //    Output(omas);                     
        //    Console.ReadKey();

        //Задание 3
        //static void Main()
        //{ 
        //int[] omas = { 30, 56, 84, -21, 12, 3 };
        //    int max = omas.Max();
        //    int min = omas.Min();
        //    Console.WriteLine($"Максимальное{max} Минимальное{min}");
        ////    Console.ReadLine();
        //}


        //Задача 4
        //static void Main()
        //{
        //    string mas = "Апельсин,Банан,Малина";
        //    string[] masArray = mas.Split(',');
        //    Array.Sort(masArray);
        //    Console.WriteLine("Отсортированный массив:");
        //    foreach (var item in masArray)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Array.Reverse(masArray);
        //    Console.WriteLine("Развернутый массив:");
        //    foreach (var item in masArray)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    Console.ReadLine();
        //}
    }
}
