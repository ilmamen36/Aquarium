using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Food
    {
        public int X { get; set; }
        public int Y { get; set; }
        Random rnd = new Random();

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

        //    public List<Kroshka> Korm { get; private set; } = new List<Kroshka>();
        //    public class Kroshka
        //    {
        //        public Kroshka(int x, int y)
        //        {
        //            this.x = x;
        //            this.y = y;
        //        }
        //        public int x;
        //        public int y;

        //        public void Sink()
        //        {
        //            if (y <= 650)
        //                y += 5;
        //        }
        //    }


        //    Random rnd = new Random();
        //    public Food(int x, int y)
        //    {
        //        for (int i = 0; i < rnd.Next(5); i++)
        //        {
        //            Korm.Add(new Kroshka(rnd.Next(x - 30, x + 30), rnd.Next(y, y + 20)));
        //        }
        //    }
    }
}
