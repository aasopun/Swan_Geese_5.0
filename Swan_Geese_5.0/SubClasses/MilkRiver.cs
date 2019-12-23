using Swan_geese_5._0.BaseClasses;
using Swan_geese_5._0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swan_geese_5._0.SubClasses
{
    class MilkRiver : River, IMilkRiver
    {
        public MilkRiver(string name, int width_in_meters, int depth_in_meters) : base(name, width_in_meters, depth_in_meters) { }

        public void Drink_my_kissel() => Console.WriteLine("-Поешь моего простого киселька с молочком — скажу.");

        public void Go_out_child() => Console.WriteLine("Река ей не сказала");

        public void Keep_staying() => Console.WriteLine("Течёт молочная река");

        public void Save_children() => Console.WriteLine("Река укрыла под кисельным бережком.");
        public override void Flowing(string words) => Console.WriteLine("Течёт " + words + ".");
    }
}
