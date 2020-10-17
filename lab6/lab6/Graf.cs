using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Graf
    {
        private double a, b, sum;
        public double get_b_a() { return b - a; }


        public void Load()
        {
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
        }

        public double Plain()
        {
            sum = Math.Pow(b, 2) / 2 - Math.Pow(a, 2) / 2;
            return sum;
        }
    }
}
