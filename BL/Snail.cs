using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BL
{
    public class Snail : LiveInAqua
    {
        public Snail(Graphics g, int x, int y)
        {
            creator = new SnailCreator();
            creator.Create(g, x, y);
            X = x - 75;
            Y = y - 47;
            Width = 150;
            Height = 95;
            this.g = g;
            TrgX = rnd.Next(80, 1400);
            TrgY = rnd.Next(650, 700);
            lifeRec = new Rectangle(x, y + 50, Width, 10);

        }

        public override void Move()
        {
            int dx = TrgX - x;
            int dy = TrgY - y;
            int stepX = 2;
            int stepY = 2;
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
            lifeRec.Y = Y + 100;
        }

        public override void SetPoint()
        {
            TrgX = rnd.Next(80, 1450);
            TrgY = rnd.Next(650, 700);
        }

        public override void Die()
        {
            Death = true;
        }

    }
}
