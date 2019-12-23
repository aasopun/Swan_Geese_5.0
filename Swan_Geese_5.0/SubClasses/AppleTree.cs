using Swan_geese_5._0.BaseClasses;
using Swan_geese_5._0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swan_geese_5._0.SubClasses
{
    class AppleTree : Tree, IAppleTree
    {
        public delegate void Num(string count);
        public event Num Operation;

        public AppleTree(string name, string type, int height_in_meters) : base(name, type, height_in_meters) { }

        public int Count_apple(int count) => count;

        public void Drop_apple(int count, int count_apple)
        {
            count_apple = Count_apple(count_apple);
            if ( count_apple >= count)
            {
                count_apple -= count;
                Operation?.Invoke("Яблоня струсилa с себя " + count + " яблок");   // 2.Вызов события
            }
            else
            {
                Operation?.Invoke("Яблоня не может струсить больше яблок чем на ней имеется"); ;
            }
        }

        public void Eat_my_apple() => Console.WriteLine("-Поешь моего лесного яблочка — скажу.");

        public void Go_out_child() => Console.WriteLine("Яблоня не сказала. Побежала девочка дальше.");

        public void Keep_staying() => Console.WriteLine("Стоит яблоня");

        public void Save_children() => Console.WriteLine("Яблоня заслонила ветвями, прикрыла листами.");
    }
}
