using Swan_geese_5._0.BaseClasses;
using Swan_geese_5._0.SubClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swan_Geese_5._0.BaseClasses
{
    class Zmey<Tanimal, Thuman> where Tanimal: Animal where Thuman: Human
    {
        public int Count_of_heads { get; set; }
        public int Height { get; set; }
        public Zmey(int count_of_heads, int height) 
        {
            this.Count_of_heads = count_of_heads;
            this.Height = height;
        }
        public void Description(string value1, string value2, string value3)
        {
            Dictionary<string, string> dragon = new Dictionary<string, string>();
            dragon.Add("Первая голова", value1);
            dragon.Add("Вторая голова", value3);
            dragon.Add("Третья голова", value3);
            foreach(KeyValuePair<string, string> dr in dragon)
            {
                Console.WriteLine(dr);
            }
        }
        public void Fire(Tanimal animal)
        {
            Console.WriteLine("Внезапно пролетел Змей и сжёг гусей-лебудей, дети остались в безопасности");
        }
        public void Speak_to_human(Thuman human) 
        {
            Console.WriteLine("Змей и сказал:\n-Не бойтесь детки, сегодня я сыт, вы в безопасности, на моей территории царит порядок, и вас никто не обидит");
        }
    }
}
