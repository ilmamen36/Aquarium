using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BL
{
    public class SnailCreator : ICreator
    {
        public void Create(Graphics g, int x, int y)
        {
            g.DrawImage(Image.FromFile("snail.png"), x - 75, y - 47, 130, 80);
        }
    }
}
