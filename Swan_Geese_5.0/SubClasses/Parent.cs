using Swan_geese_5._0.BaseClasses;
using Swan_geese_5._0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swan_geese_5._0.SubClasses
{
    class Parent : Human, IParent
    {
        public Parent(string name, string gender, int age) : base(name, gender, age) { }

        public void Ask(Child child) => Console.WriteLine("-" + child.Name + ", мы пойдем на работу, береги братца! Не ходи со двора, будь умницей — мы купим тебе платочек.");

        public void Go_out_from_home() => Console.WriteLine("Отец с матерью ушли.");

        public void Come_to_home() => Console.WriteLine("А тут и отец с матерью пришли.");

        public void Keep_live() => Console.WriteLine(" Жили мужик да баба. У них была дочка да сынок маленький.");
    }
}
