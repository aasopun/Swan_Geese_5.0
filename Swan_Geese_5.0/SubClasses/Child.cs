using Swan_geese_5._0.BaseClasses;
using Swan_geese_5._0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swan_geese_5._0.SubClasses
{
    class Child : Human, ISister
    {
        int goals;
        public int Lessons_goal 
        {
            get { return goals; }
            set 
            {
                if(value<0 && value > 5)
                {
                    throw new Exception("Введите правильное знчение!");
                }
                else
                {
                    goals = value;
                }
            }
        }
        public Child(string name, string gender, int age, int leessons_goal) : base(name, gender, age) 
        {
            this.Lessons_goal = Lessons_goal;
        }

        public string FullName(string name, string lastname) => name + " " + lastname;

        public void Come_to_hut() => Console.WriteLine("Вдруг видит — стоит избушка на курьей ножке, об одном окошке, кругом себя поворачивается.");

        public void Drink_kissel() => Console.WriteLine("Девочка выпила киселику да спасибо сказала.");

        public void Eat_apple() => Console.WriteLine("Девочка поскорее съела яблочко и спасибо сказала.");

        public void Eat_cake() => Console.WriteLine("Девочка скорее — пирожок в рот.");

        public void Where_brother() => Console.WriteLine("Подскажи пожалуйста, где мой братец?");

        public void Go_out_from_hut() => Console.WriteLine("Девочка взяла братца и побежала.");

        public void Go_out_from_home() => Console.WriteLine("Побежала сестрица на улицу, заигралась, загулялась.");

        public void Not_drink_kissel() => Console.WriteLine("-У моего батюшки и сливочки не едятся...");

        public void Not_eat_apple() => Console.WriteLine("-У моего батюшки и садовые не едятся...");

        public void Not_eat_cake() => Console.WriteLine("-Стану я ржаной пирог есть! У моего батюшки и пшеничные не едятся...");

        public void Search_in_fields() => Console.WriteLine("Долго она бегала по полям, по лесам. День клонится к вечеру, делать нечего — надо идти домой.");

        public void Spin() => Console.WriteLine("Сидит девочка, прядёт");

        public void Stay_at_hut() => Console.WriteLine("И остались дети в избушке, да не видел их никто до сегодняшнего дня...");

        public void Run_out_from_geese() => Console.WriteLine("Девочка опять побежала. Бежит, бежит, уж недалеко осталось. Тут гуси-лебеди увидели ее, загоготали — налетают, крыльями бьют, того гляди, братца из рук вырвут.");

        public void Run() => Console.WriteLine("Бросилась девочка их доганять");

        public void Search() => Console.WriteLine("Выбежала она в чистое поле и только видела: метнулись вдалеке лебеди и пропали за темным лесом. Тут она догадалась, что они унесли её братца: про гусей-лебедей давно шла дурная слава — что они пошаливали, маленьких детей уносили.");

        public void Stay_at_home() => Console.WriteLine("И осталась сестрица дома, поиграла с братом, подождала родителей да получила платочек.");

        public void Come_to_home() => Console.WriteLine("И побежала сестрица с братцем домой.");

        public void Cry() => Console.WriteLine("Вернулась девочка, глядь — братца нету! Ахнула, кинулась туда-сюда — нету! Она его кликала, слезами заливалась, причитывала, что худо будет от отца с матерью");

        public void Forget() => Console.WriteLine("Дочка позабыла, что ей приказывали: посадила братца на травке под окошко, сама побежала на улицу, заигралась, загулялась.");

        public void Ask_apple_tree(AppleTree appleTree) => Console.WriteLine("-" + appleTree.Name + " матушка, спрячь меня!");

        public void Ask_oven(Oven oven) => Console.WriteLine("-" + oven.Name + " матушка, спрячь меня!");

        public void Ask_river(MilkRiver river) => Console.WriteLine("-" + river.Name + " матушка, спрячь меня!");

        public void Give_to_eat() => Console.WriteLine("Девочка дала ей кашки.");

        public void Not_eat() => Console.WriteLine("Не захотела кушать девочка, побежали она с братиком, поймали их гуси-лебеди. Больше о них не слышали...");
    }
}
