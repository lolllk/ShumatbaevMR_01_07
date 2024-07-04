using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShumatbaevMR_01_04
{
    public class BraidCable : Cable //Создание класса с унаследованием
    {
        public bool HasBraid { get; set; }

        public BraidCable(string Name, int strands, double diametr, bool hasbraid) : base(Name, strands, diametr) //Унаследование параметров с основного класса
        {
            HasBraid = hasbraid;
        }

    

        public double Qp() //Вычисление Qp 
        {
            if (HasBraid)
            {
                return 2.1 * Q();
            }
            else
            {
                return 0.7 * Q();
            }
        }
        public new void PrintInfo() //Дополнение класса вывода информации 
        {
            base.PrintInfo();
            Console.WriteLine($"Наличие оплетки: {HasBraid}");
            Console.WriteLine($"Qp: {Qp()}");
        }
    }
}
