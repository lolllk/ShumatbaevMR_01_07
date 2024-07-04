using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShumatbaevMR_01_04;

namespace ShumatbaevMR_01_04
{
    public class Cable //Создание класса Cable
    {
        public string Name { get; set; } 
        public int Strands { get; set; }
        public double Diametr { get; set; }

        public Cable(string type, int strands,double diametr) //Присваивание значение для класса Cable
        {
            Name = type;
            Strands = strands;
            Diametr = diametr;
        }

        public virtual double Q() //Вычисление Q для дальнейших рассчетах
        {
            return Diametr / Strands;
        }

        public void PrintInfo() //Создание класса для вывода информации
        {
            Console.WriteLine($"Тип кабеля: {Name}");
            Console.WriteLine($"Кол-во жил: {Strands}");
            Console.WriteLine($"Диаметр: {Diametr}");
            Console.WriteLine($"Q: {Q()}");
        }

    }
}
