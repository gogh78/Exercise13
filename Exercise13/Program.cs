using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Program
    {//Задан класс Building, который описывает здание. Класс содержит следующие элементы:
     //адрес здания;
     //длина здания;
     //ширина здания;
     //высота здания.
     //В классе Building нужно реализовать следующие методы:
     //•	конструктор с 4 параметрами;
     //•	свойства get/set для доступа к полям класса;
     //•	метод Print(), который выводит информацию о здании.
     //Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность.
     //В классе MultiBuilding реализовать следующие элементы:
     //•	конструктор с 5 параметрами – реализует вызов конструктора базового класса;
     //•	свойство get/set доступа к внутреннему полю класса;
     //•	метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
     //Класс MultiBuilding сделать таким, что не может быть унаследован.

        static void Main(string[] args)
        {
            // Building building = new Building("ул.Самарская д.57А", 50, 12, 9);
            MultiBuilding multiBuilding = new MultiBuilding("ул.Самарская д.57А", 50, 12, 9, 2);
            multiBuilding.Print();
            Console.ReadKey();
        }
    }
    class Building
    {
        public string Adress { get; set; }
        public int Lenght { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }

        public Building(string adress, int lenght, int width, int height)
        {
            Adress = adress;
            Lenght = lenght;
            Width = width;
            Height = height;
        }
        public void Print()
        {
            Console.WriteLine("Адресс здания {0}", Adress);
            Console.WriteLine("Длина здания {0} м", Lenght);
            Console.WriteLine("Ширина здания {0} м", Width);
            Console.WriteLine("Высота здания {0} м", Height);
        }
    }
    sealed class MultiBuilding : Building
    {
        public int Storeys { get; set; }
        public MultiBuilding(string adress, int lenght, int width, int height, int storeys) : base(adress, lenght, width, height)
        {
            Adress = adress;
            Lenght = lenght;
            Width = width;
            Height = height;
            Storeys = storeys;
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine("Количество этажей здания - {0}", Storeys);
        }
    }
}
