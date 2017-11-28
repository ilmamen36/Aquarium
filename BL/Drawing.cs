using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace BL
{
    public class Drawing
    {
        Bitmap bmp = new Bitmap(Image.FromFile("background.png"));
        Graphics g;
        Image leftfish = Image.FromFile("fish.png");
        Image rightfish = Image.FromFile("fish.png");
        Image back = Image.FromFile("background.png");
        Image leftdie = Image.FromFile("fish.png");
        Image rightdie = Image.FromFile("fish.png");
        Image leftdiesnail = Image.FromFile("snail.png");
        Image rightdiesnail = Image.FromFile("snail.png");
        Image leftsnail = Image.FromFile("snail.png"); 
        Image rightsnail = Image.FromFile("snail.png"); 

        public Drawing()
        {
            rightfish.RotateFlip(RotateFlipType.RotateNoneFlipX);
            rightdie.RotateFlip(RotateFlipType.RotateNoneFlipX);
            rightdie.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            leftdie.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            leftsnail.RotateFlip(RotateFlipType.RotateNoneFlipX);
            leftdiesnail.RotateFlip(RotateFlipType.RotateNoneFlipX);
            leftdiesnail.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            rightdiesnail.RotateFlip(RotateFlipType.RotateNoneFlipY);
        }

        public Bitmap DrawAll(Aquarium sea)
        {
            bmp.Dispose();
            bmp = new Bitmap(back);
            g = Graphics.FromImage(bmp);
            DrawMove(sea.AllFish);
            if (sea.Ohapka.Count != 0)
                DrawFood(sea.Ohapka);
            return bmp;
        }

        private void DrawMove(ListOfAquaPeople swimmers)
        {
            for (int i = 0; i < swimmers.residents.Count; i++)
            {
                if (swimmers.residents.ElementAt(i).Death)
                {
                    g.DrawImage(Image.FromFile("death.png"), swimmers.residents.ElementAt(i).X, swimmers.residents.ElementAt(i).Y, 150, 150);
                    swimmers.residents.RemoveAt(i);
                    continue;                    
                }
                if(swimmers.residents.ElementAt(i).Y < 650)
                    DrawFish(swimmers.residents.ElementAt(i));
                else
                    DrawSnail(swimmers.residents.ElementAt(i));
                DrawHealth(swimmers.residents.ElementAt(i).lifeRec, swimmers.residents.ElementAt(i).health);
            }
        }

        private void DrawFish(LiveInAqua fish)
        {
            if (fish.turn)
            {
                if (fish.health != 0)
                {
                    g.DrawImage(rightfish, fish.X, fish.Y, fish.Width, fish.Height);
                    fish.turn = false;
                }
                else
                {
                    g.DrawImage(rightdie, fish.X, fish.Y, fish.Width, fish.Height);
                }
            }
            else
            {
                if (fish.health != 0)
                {
                    g.DrawImage(leftfish, fish.X, fish.Y, 150, 95);
                }
                else
                {
                    g.DrawImage(leftdie, fish.X, fish.Y, fish.Width, fish.Height);
                }
            }
        }

        private void DrawSnail(LiveInAqua snail)
        {
            if (snail.turn)
            {
                if (snail.health != 0)
                {
                    g.DrawImage(rightsnail, snail.X, snail.Y, snail.Width, snail.Height);
                    snail.turn = false;
                }
                else
                {
                    g.DrawImage(rightdiesnail, snail.X, snail.Y, snail.Width, snail.Height);
                }
            }
            else
            {
                if (snail.health != 0)
                {
                    g.DrawImage(leftsnail, snail.X, snail.Y, 150, 95);
                }
                else
                {
                    g.DrawImage(leftdiesnail, snail.X, snail.Y, snail.Width, snail.Height);
                }
            }
        }


        private void DrawHealth(Rectangle rec, int health)
        {
            if (health > 0)
            {
                Font myFont = new Font("Times New Roman", 13, FontStyle.Bold);
                int R = (int)(0 + 4.18 * (100 - health));
                int G = 209;
                if (R > 207)
                {
                    G = (int)(209 - 4.18 * (50 - health));
                    R = 209;
                }
                int B = 0;
                SolidBrush brush = new SolidBrush(Color.FromArgb(R, G, B));
                g.FillRectangle(brush, rec.X, rec.Y, rec.Width * health / 100, rec.Height);
                g.DrawRectangle(Pens.Black, rec);
                g.DrawString(health.ToString(), myFont, Brushes.Black, rec.Location.X + rec.Size.Width / 2 - 10, rec.Location.Y - rec.Size.Height / 2);
            }
        }

        public void DrawFood(List<Food> eda)
        {
            foreach (Food food in eda)
                foreach (Food.Kroshka kpoxa in food.Korm)
                    g.DrawImage(Image.FromFile("kroshka.png"), kpoxa.x, kpoxa.y, 12, 12);
        }
    }
}
