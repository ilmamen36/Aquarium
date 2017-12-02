using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Objects
    {
        public List<Food> Korm { get; set; } = new List<Food>();
        public List<WaterWood> Trees {get; set;} = new List<WaterWood>();
        protected static Random rnd = new Random();

        public class Food
        {
            public int X { get; set; }
            public int Y { get; set; }
            

            public Food(int x, int y)
            {
                
                X = rnd.Next(x - 30, x + 30);
                Y = rnd.Next(y, y + 20);
            }

            public void Sink()
            {
                if (Y <= 650)
                    Y += 3;
            }
        }

        public class WaterWood
        {

        }
    }
}
