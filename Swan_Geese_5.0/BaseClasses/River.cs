using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swan_geese_5._0.BaseClasses
{
    public abstract class River
    {
        private int width_in_meters;
        private int depth_in_meters;
        public string Name { get; set; }
        public int Width_in_meters
        {
            get { return width_in_meters; }
            set
            {
                if (value > 0 && value < 220000000)
                {
                    width_in_meters = value;
                }
                else
                {
                    throw new Exception("Введите правильное знчение!");
                }
            }
        }
        public int Depth_in_meters
        {
            get { return depth_in_meters; }
            set
            {
                if (value > 0 && value < 4600000)
                {
                    depth_in_meters = value;
                }
            }
        }
        public River(string name, int width_in_meters, int depth_in_meters)
        {
            this.Name = name;
            this.Width_in_meters = width_in_meters;
            this.Depth_in_meters = depth_in_meters;
        }
        public virtual void Flowing(string words) => Console.WriteLine(words); 
    }
}
