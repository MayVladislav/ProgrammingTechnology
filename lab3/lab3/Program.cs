using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters;

namespace lab3
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
            int t = 0, N = 20, i=1;
            double x = 0, y =0, chis =0,znam =0,Z=0;
            
            t = Convert.ToInt32(Console.ReadLine());
            N = Convert.ToInt32(Console.ReadLine());
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());

            if (t == 0)
            {
              for (i = 1; i <= N; i++)
                {
                    znam = i * (i + 2) * (i + 4);
                    if (i == 1)
                    {
                        Z += 1;
                    }
                    else if (i == 2)
                    {
                        chis = 1 - Math.Pow(Math.Cos(y), i - 1);
                    }
                    else if ((i % 2 == 0) && (i != 2))
                    {
                        chis = Math.Pow(x, i - 2) - Math.Pow(Math.Cos(y), i - 1);
                    }
                    else
                    {
                        chis = -(Math.Pow(y, i - 2) + Math.Pow(Math.Cos(x), i - 1));
                    }
                    Z += chis / znam;
                }
            }


            if (t == 1)
            {
                i = 1;
                while (i <= N)
                {
                    znam = i * (i + 2) * (i + 4);
                    if (i == 1)
                    {
                        Z += 1;
                    }
                    else if (i == 2)
                    {
                        chis = 1 - Math.Pow(Math.Cos(y), i - 1);
                    }
                    else if ((i % 2 == 0) && (i != 2))
                    {
                        chis = Math.Pow(x, i - 2) - Math.Pow(Math.Cos(y), i - 1);
                    }
                    else
                    {
                        chis = -(Math.Pow(y, i - 2) + Math.Pow(Math.Cos(x), i - 1));
                    }
                    Z += chis / znam;
                    i++;
                }
            }


            if (t == 2)
            {
                i = 1;
                do
                {
                    znam = i * (i + 2) * (i + 4);
                    if (i == 1)
                    {
                        Z += 1;
                    }
                    else if (i == 2)
                    {
                        chis = 1 - Math.Pow(Math.Cos(y), i - 1);
                    }
                    else if (i % 2 == 0)
                    {
                        chis = Math.Pow(x, i - 2) - Math.Pow(Math.Cos(y), i - 1);
                    }
                    else
                    {
                        chis = -(Math.Pow(y, i - 2) + Math.Pow(Math.Cos(x), i - 1));
                    }
                    Z += chis / znam;
                    i++;
                } while (i <= N);
            }

            Console.WriteLine($"Значение Z ={Z}");



            Console.SetOut(save_out);
            new_out.Close();
            Console.SetIn(save_in);
            new_in.Close();

            Console.ReadKey();
        }
    }
}
