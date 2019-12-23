using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swan_geese_5._0.BaseClasses
{
    public abstract class Human
    {
        private string gender;
        private int age;
        public string Name { get; set; }
        public string Gender
        {
            get { return gender; }
            set
            {
                if (value == "Мужской" && value == "Женский")
                {
                    gender = value;
                }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0 && value < 120)
                {
                    age = value;
                }
                else
                {
                    throw new Exception("Введите правильное знчение!");
                }
            }
        }
        public Human(string name, string gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }
        public virtual void Say(string words) => Console.WriteLine(words); 
        public virtual void Do(string words) => Console.WriteLine(words); 
    }
}
