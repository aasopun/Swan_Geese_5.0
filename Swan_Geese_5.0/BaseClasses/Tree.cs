using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swan_geese_5._0.BaseClasses
{
    public abstract class Tree
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Height_in_meters { get; set; }
        public Tree(string name, string type, int height_in_meters)
        {
            this.Name = name;
            this.Type = type;
            this.Height_in_meters = height_in_meters;
        }
        public virtual void Grow_up(string words) => Console.WriteLine(words); 
    }
}
