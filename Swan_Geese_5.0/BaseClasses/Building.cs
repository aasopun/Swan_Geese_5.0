using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swan_geese_5._0.BaseClasses
{
    public abstract class Building
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Building(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }
        public virtual void Do_something(string words) => Console.WriteLine(words);
    }
}
