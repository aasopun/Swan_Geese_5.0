using Swan_geese_5._0.SubClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swan_geese_5._0.Interfaces
{
    interface IParent
    {
        void Keep_live();
        void Ask(Child child);
        void Go_out_from_home();
        void Come_to_home();
    }
}
