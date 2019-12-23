using Swan_geese_5._0.BaseClasses;
using Swan_geese_5._0.SubClasses;
using Swan_Geese_5._0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swan_geese_5._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent man = new Parent("Мужик", "Мужской", 52);
            Parent woman = new Parent("Баба", "Женский", 44);
            Child daughter = new Child("Доченька", "Женский", 12, 4);
            Child son = new Child("Сынок", "Мужской", 8, 1);
            Goose goose = new Goose("Гуси-лебеди", "Птица", "Коричневые", 1, 1, 2);
            Oven oven = new Oven("Печка", "Еда");
            AppleTree apple_tree = new AppleTree("Яблоня", "Фрукты", 21);
            MilkRiver milk_river = new MilkRiver("Молочная река", 100, 21);
            GrandParent<Human> granny_yaga = new GrandParent<Human>("Баба-Яга", "Женский", 119);
            Mouse mouse = new Mouse("Мышка", "Грызун", "Серый", 1, 1, 4);

            //правильная концвока при 2, 2, 2, 2, 1, 1, 1, 1 включая рандомы
            //Класс Zmey(в нем находится так же dictionary) и GrandParent обобщенные

            StoryTeller storyTeller = new StoryTeller();
            storyTeller.TellStrory(man, woman, daughter, son, goose, oven, apple_tree, milk_river, granny_yaga, mouse);

            Console.ReadKey();
        }
    }
}
