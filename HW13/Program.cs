using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13
{
    class Program
    {
        // Задан класс Building, который описывает здание. Класс содержит следующие элементы:
        //•	адрес здания;
        //•	длина здания;
        //•	ширина здания;
        //•	высота здания.
        //В классе Building нужно реализовать следующие методы:
        //•	конструктор с 4 параметрами;
        //•	свойства get/set для доступа к полям класса;
        //•	метод Print(), который выводит информацию о здании.
        //Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность.В классе MultiBuilding реализовать следующие элементы:
        //•	конструктор с 5 параметрами – реализует вызов конструктора базового класса;
        //•	свойство get/set доступа к внутреннему полю класса;
        //•	метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
        //Класс MultiBuilding сделать таким, что не может быть унаследован.

        static void Main(string[] args)
        {
            double L, W, H;
            Console.WriteLine("Внесите адрес дома");
            string Address = Console.ReadLine();
            Console.WriteLine("Внесите длину дома");
            L = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Внесите ширину дома");
            W = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Внесите высоту дома");
            H= Convert.ToDouble(Console.ReadLine());
            Building building = new Building(Address, L, W, H);
            building.Print();

            
            Console.WriteLine("Внесите этажность дома");
            double storeys = Convert.ToDouble(Console.ReadLine());
            MultiBuilding multiBuilding = new MultiBuilding(Address, L, W, H, (uint)storeys);
            multiBuilding.Print();

            Console.Write("Нажмите любую клавишу для выхода");
            Console.ReadLine();
        }

        private class Building
        {
            private String address;
            private double length;
            private double width;
            private double height;

            public String Address
            {
                get { return address; }
                set
                {
                    address = value;
                }
            }

            public double Length
            {
                get { return length; }
                set
                {
                    length = value;
                }
            }

            public double Width
            {
                get { return width; }
                set
                {
                    width = value;
                }
            }

            public double Height
            {
                get { return height; }
                set
                {
                    height = value;
                }
            }

            public Building(String address, double length, double width, double height)
            {
                this.address = address;
                this.length = length;
                this.width = width;
                this.height = height;
            }

            public void Print()
            {
                Console.WriteLine("Address={0}\nLength={1}\nWidth={2}\nHeight={3}",
                    this.address, this.length, this.width, this.height);
            }
        }

        private sealed class MultiBuilding : Building
        {
            private uint storeys;

            public uint Storeys
            {
                get { return storeys; }
                set
                {
                    storeys = value;
                }
            }

            public MultiBuilding(String address, double length, double width, double height, uint storeys) :
                base(address, length, width, height)
            {
                this.storeys = storeys;

            }

            public void Print()
            {
                base.Print();
                Console.WriteLine("Storeys={0}", this.storeys);
            }
        }
    }
}
