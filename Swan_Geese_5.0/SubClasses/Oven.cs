using Swan_geese_5._0.BaseClasses;
using Swan_geese_5._0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swan_geese_5._0.SubClasses
{
    class Oven : Building, IOven
    {
        public Oven(string name, string type) : base(name, type) { }

        public delegate void Num(string count);
        public event Num Operation;

        public int Count_cake(int count) => count;

        public void Drop_cake(int count, int count_cake)
        {
            count_cake = Count_cake(count_cake);
            if (count_cake >= count)
            {
                count_cake -= count;
                Operation?.Invoke("Печь испекла " + count + " пирожков");   // Вызов события
            }
            else
            {
                Operation?.Invoke("Печь не может дать больше пирогов чем имеется"); ;
            }
        }

        public void Eat_my_cake() => Console.WriteLine("-Поешь моего ржаного пирожка.");

        public void Go_out_child() => Console.WriteLine("Не сказала печка.");

        public void Keep_staying() => Console.WriteLine("Стоит печь");

        public void Save_children() => Console.WriteLine("Спрятала печка деток в устьице");
    }
}
