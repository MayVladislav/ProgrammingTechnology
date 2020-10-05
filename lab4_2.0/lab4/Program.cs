using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters;

namespace lab4
{
    class Program

    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
            int N = Convert.ToInt32(Console.ReadLine()); //считывание N
            string str_all = Console.ReadLine();   // Считывание всей строки
            int[] mas = new int[N];  // создание массива целых чисел
            string [] str_elem = str_all.Split(' ');  // разбиваем строку str_all на элементы и записываем их в массив str_elem

            for(int i=0; i<N; i++) 
            {
                mas[i] = Convert.ToInt32(str_elem[i]); //заполняем массив целых чисел
            }
            int min_5 = -1;
            int max_o = 0; //изменено значение с 1 на 0**исправлено**
            int s = 0;
            float sa_p = 0;
            int k = 0; // счетчик положительных чисел**исправлено**
            // макс крат 5
            for (int i=0; i < N; i++)
            {
                if ((mas[i] % 5 == 0 ) && (mas[i] > min_5))
                {
                    min_5 = mas[i];           
                }
            }
            // > ср арифметическое пол чисел
            for (int i = 0; i < N; i++)
            {
                if (mas[i] > 0)
                {
                    s+= mas[i];
                    k += 1;
                }
            }
            sa_p = 1.0f * s / k;
            // нхожд максимума среди отриц чисел
            for (int i = 0; i < N; i++)
            {
                if (mas[i] < max_o)
                {
                    max_o = mas[i];
                }
            }
            if (min_5 != -1)
            {
                Console.WriteLine($"знач кр5 ={min_5}");
            }
            else
            {
                Console.WriteLine("No");
            }
             // нахождение  и вывод пол чисел > ср ариф
             for (int i = 0; i < N; i++)
             {
                if (mas[i] > sa_p)
                {
                 Console.WriteLine($"Значения большие ср арифметического положительных ={mas[i]}");
                }
             }
             // вывод максимального отрицательного числа если оно есть
                if (max_o != 0)
                {
                 Console.WriteLine($"макс отриц= {max_o}");
                }
                else
                {
                 Console.WriteLine("No");
                }


            Console.SetOut(save_out);
            new_out.Close();
            Console.SetIn(save_in);
            new_in.Close();

            Console.ReadKey();
            }
    }
}
