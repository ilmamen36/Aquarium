using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BL
{
    public abstract class LiveInAqua
    {
        protected int x;
        protected int y;
        protected int width;
        protected int height;
        public bool Death { get; protected set; } = false;

        //public double kX { get; set; } = 1;
        //public double kY { get; set; }= 1;
        public int TrgX { get; protected set; }
        public int TrgY { get; protected set; }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int health = 55;
        public Rectangle lifeRec;
        public bool turn = false;
        protected Graphics g;
        protected Random rnd = new Random();
        public ICreator creator;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public void Create()
        {
            creator.Create(g, x, y);
        }

        public abstract void Move();

        public virtual void SetPoint()
        {
            TrgX = rnd.Next(80, 1450);
            TrgY = rnd.Next(40, 650);
        }

        public virtual void Die()
        {
            if (Y > 25)
                Y -= 7;
            else
                Death = true;
        }

        public virtual void GoEat(Objects something)
        {
            List<Objects.Food> Korm = something.Korm;
            double min = 5000;
            int indexI = -1;
            double distance;
            for (int i = 0; i < Korm.Count(); i++)
            {
                distance = Math.Sqrt((X - Korm.ElementAt(i).X) * (X - Korm.ElementAt(i).X)
                    + (Y - Korm.ElementAt(i).Y) * (Y - Korm.ElementAt(i).Y));
                if (distance < min)
                {
                    min = distance;
                    indexI = i;
                }
            }
            if (min <= 20)   
            {
                Korm.RemoveAt(indexI);
                health += 45;
                return;
            }
            if (indexI > -1)
            {
                TrgX = Korm.ElementAt(indexI).X;
                TrgY = Korm.ElementAt(indexI).Y;
            }
        }
    }
}
