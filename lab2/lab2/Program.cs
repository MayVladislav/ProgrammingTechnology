using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab2
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

            double a, b, c, d, e, s, k;
            //Console.Write("Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите c: ");
            c = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите d: ");
            d = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите e: ");
            e = Convert.ToDouble(Console.ReadLine());
            s = b / (a - Math.Pow(c - d, 0.5));
            k = 100 / (Math.Pow(c - 3 * d, 0.5)) + 100 / (Math.Pow(4 * e - a, 0.5));
           if ((s/1 !=s) || (k/1 !=k)) 
            {
                Console.WriteLine("ERROR");
                    }
            else
            {
                Console.WriteLine("Значение s = {0:0.00}",s);
                Console.WriteLine("Значение k = {0:0.00}", k);
                
            }
               Console.SetOut(save_out);
               new_out.Close();
               Console.SetIn(save_in);
               new_in.Close();
           
            Console.ReadKey();
        }
    }
}
