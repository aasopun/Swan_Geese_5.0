using Swan_geese_5._0.BaseClasses;
using Swan_geese_5._0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swan_geese_5._0.SubClasses
{
    class GrandParent<Thuman> : Human, IGrannyYaga where Thuman: Human
    {
        public GrandParent(string name, string gender, int age) : base(name, gender, age) { }

        public void Ask_girl(Human human)
        {
            Console.WriteLine(human.Name + " спрашивает:\n-Девица, прядешь ли?");
        }

        public void Come_to_hut(Human human)
        {
            Console.WriteLine(human.Name + " баню вытопила и пошла за девочкой. А в избушке нет никого. Баба-яга закричала:\n -Гуси-лебеди! Летите в погоню! Сестра братца унесла!");
        }

        public void Give_spin(Human human)
        {
            Console.WriteLine(human.Name + " дала ей веретено, а сама ушла.");
        }
    }
}
