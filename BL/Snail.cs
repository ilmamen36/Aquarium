using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BL
{
    public class Snail : LiveInAqua//, ICreator
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
            TrgY = rnd.Next(630, 750);
            lifeRec = new Rectangle(x, y + 50, Width, 10);

        }

        public override void Move()
        {
            int dx = TrgX - x;
            int stepX = 1;
            if (Math.Abs(dx) > 2)
            {
                if (dx < 0)              // улитка правее точки
                    x -= stepX;
                else
                {
                    x += stepX;
                    turn = true;
                }
            }
            lifeRec.X = X;
        }

        public override void SetPoint()
        {
            TrgX = rnd.Next(80, 1450);
            TrgY = rnd.Next(630, 750);
        }

        public override void Die()
        {
            Death = true;
        }

    }
}
