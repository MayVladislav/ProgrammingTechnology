using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Майор Владислав Юрьевич");
            Console.WriteLine("Группа ИНС-Б-О-19-1, шифр специальности 09.03.02");
            Console.WriteLine("Дата рождения: 27.02.2002");
            Console.WriteLine("Город Буденновск");
            Console.WriteLine("Любимый предмет в школе Математика");
            Console.WriteLine("Люблю играть в футбол, гулять с друзьями и путешествовать");



            float _G_1, y1, y2, y3;
            y1 = 10.2F;
            y2 = 15;
            y3 = 1;
            _G_1 = y1 + y2 + y3 - (y1 + y2 + y3) / 3;
            

            Console.WriteLine("Значение _G_1 = {0}", _G_1);
            Console.ReadKey();
        } 
    }
}
