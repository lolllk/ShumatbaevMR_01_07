using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShumatbaevMR_01_04;

namespace ShumatbaevMR_01_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            int StrandsCount;
            double Diametr;
            int Hasbraid;
            int Again = 1;
            while (Again == 1)
            {
                Console.WriteLine("Введите название кабеля:");
                Name = Console.ReadLine();
                Console.WriteLine("Введите кол-во жил:");
                StrandsCount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите диаметр:");
                Diametr = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Кабель с оплеткой (1 - да, 0 - нет): ");
                Hasbraid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Добавить еще один кабель? (1 - да, 0 - нет)");
                if (Hasbraid == 1) //Кабель в оплетке
                {
                    BraidCable braidcable = new BraidCable(Name, StrandsCount, Diametr, true); //Создание объекта "Кабель с оплеткой"
                    braidcable.PrintInfo(); //Вывод информации о кабеле с оплеткой
                }
                else //Кабель без оплетки
                {
                    Cable basicCable = new Cable(Name, StrandsCount, Diametr); //Создание объекта "Базовый кабель"
                    basicCable.PrintInfo(); //Вывод информации о кабеле без оплетки
                }
            }
            
            Console.ReadKey();
        }
    }
}
