using Swan_geese_5._0.BaseClasses;
using Swan_geese_5._0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swan_geese_5._0.SubClasses
{
    class Mouse : Animal, IMouse
    {
        public Mouse(string name, string type, string color, double weight_in_meters, double height_in_meters, int count_of_foots)
        : base(name, type, color, weight_in_meters, height_in_meters, count_of_foots) { }

        public override void Run() => Console.WriteLine("Тут мышка выбегает из-под печки");

        public void Ask_to_eat() => Console.WriteLine("-Дай мне кашки, я тебе добренькое скажу.");

        public void Ask_to_run() => Console.WriteLine("-Баба пошла баню топить. Она тебя вымоет-выпарит, в печь посадит, зажарит и съест, сама на твоих костях покатается. Не дожидайся, бери братца, беги, а я за тебя кудель попряду.");

        public void Lie() => Console.WriteLine("-Пряду, бабушка...");
    }
}
