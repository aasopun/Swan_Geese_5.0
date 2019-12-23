using Swan_geese_5._0.BaseClasses;
using Swan_geese_5._0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swan_geese_5._0.SubClasses
{
    class Goose : Animal, IGoose
    {
        public delegate void Num(string count);
        public event Num Operation;

        public Goose(string name, string type, string color, double weight_in_meters, double height_in_meters, int count_of_foots)
        : base(name, type, color, weight_in_meters, height_in_meters, count_of_foots) { }

        public void Count_goose(int count) => Operation?.Invoke("Вылупилось с яиц " + count + " гусей");

        public void Fly() => Console.WriteLine("Летят гуси-лебеди дальше");

        public void Not_see() => Console.WriteLine("Гуси-лебеди не увидали, пролетели мимо.");

        public void Steal_child() => Console.WriteLine("Налетели гуси-лебеди, подхватили мальчика, унесли на крыльях.");
    }
}
