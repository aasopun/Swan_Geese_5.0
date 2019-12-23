using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swan_geese_5._0.BaseClasses
{
    public abstract class Animal
    {
        private int count_of_foots;
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public double Weight_in_meters { get; set; }
        public double Height_in_meters { get; set; }
        public int Count_of_foots
        {
            get { return count_of_foots; }
            set
            {
                if (value > 0 && value < 5)
                {
                    count_of_foots = value;
                }
                else
                {
                    throw new Exception("Введите правильное знчение!");
                }
            }
        }
        public Animal(string name, string type, string color, double weight_in_meters, double height_in_meters, int count_of_foots)
        {
            this.Name = name;
            this.Type = type;
            this.Color = color;
            this.Weight_in_meters = weight_in_meters;
            this.Height_in_meters = height_in_meters;
            this.Count_of_foots = count_of_foots;
        }
        public virtual void Voice() { }
        public virtual void Run() { }
    }
}
