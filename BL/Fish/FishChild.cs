using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BL
{
    public class FishChild : LiveInAqua
    {
        public FishChild(Graphics g, int x, int y)
        {
            creator = new FishChildCreator();
            creator.Create(g, x, y);
            X = x - 25;
            Y = y - 30;
            Width = 50;
            Height = 32;
            this.g = g;
            TrgX = rnd.Next(80, 1450);
            TrgY = rnd.Next(40, 650);
            lifeRec = new Rectangle(x, y + Height, Width, 10);
        }

        public override void Move()
        {
            int dx = TrgX - x;
            int dy = TrgY - y;
            int stepX = 6;
            int stepY = 3;

            if (Math.Abs(dx) > stepX)
            {
                if (dx < 0)              // рыбка правее точки
                    x -= stepX;
                else
                {
                    x += stepX;
                    turn = true;
                }
            }

            if (Math.Abs(dy) > stepY)
            {
                if (dy < 0)                // рыбка ниже точки
                    y -= stepY;
                else
                    y += stepY;
            }
            lifeRec.X = X;
            lifeRec.Y = Y + 30;
        }
    }
}
