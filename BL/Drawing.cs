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
        public bool Light { get; set; } = true; //свет вкл или выкл
        public bool Christmas = false;
        Bitmap bmp = new Bitmap(Image.FromFile("background.png"));
        Graphics g;
        Image leftf = Image.FromFile("fishChr.png");
        Image rightf = Image.FromFile("fishChr.png");
        Image leftd = Image.FromFile("fishChr.png");
        Image rightd = Image.FromFile("fishChr.png");
        Image leftds = Image.FromFile("snailChr.png");
        Image rightds = Image.FromFile("snailChr.png");
        Image lefts = Image.FromFile("snailChr.png");
        Image rights = Image.FromFile("snailChr.png");
        Image backp = Image.FromFile("backgroundChr.png");
        Image backp2 = Image.FromFile("background2Chr.png");

        Image leftfish = Image.FromFile("fish.png");
        Image rightfish = Image.FromFile("fish.png");
        Image back = Image.FromFile("background.png");
        Image back2 = Image.FromFile("background2.png");
        Image leftdie = Image.FromFile("fish.png");
        Image rightdie = Image.FromFile("fish.png");
        Image leftdiesnail = Image.FromFile("snail.png");
        Image rightdiesnail = Image.FromFile("snail.png");
        Image leftsnail = Image.FromFile("snail.png");
        Image rightsnail = Image.FromFile("snail.png");

        Image food = Image.FromFile("kroshka.png");
        Image waterwood = Image.FromFile("waterwood.png");

        public Drawing()
        {
            rightf.RotateFlip(RotateFlipType.RotateNoneFlipX);
            rightd.RotateFlip(RotateFlipType.RotateNoneFlipX);
            rightd.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            leftd.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            lefts.RotateFlip(RotateFlipType.RotateNoneFlipX);
            leftds.RotateFlip(RotateFlipType.RotateNoneFlipX);
            leftds.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            rightds.RotateFlip(RotateFlipType.RotateNoneFlipY);

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
            if (Light)
            {
                if (Christmas)
                    bmp = new Bitmap(backp);
                else
                    bmp = new Bitmap(back);
            }

            else
            {
                if (Christmas)
                    bmp = new Bitmap(backp2);
                else
                    bmp = new Bitmap(back2);
            }
            g = Graphics.FromImage(bmp);
            DrawWaterWood(sea.something.Trees);
            DrawMove(sea.AllFish);
            if (sea.something.Korm.Count != 0)
                DrawFood(sea.something.Korm);
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
                if (swimmers.residents.ElementAt(i).Y < 650)
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
                    if (Christmas)
                        g.DrawImage(rightf, fish.X, fish.Y, fish.Width, fish.Height);
                    else
                        g.DrawImage(rightfish, fish.X, fish.Y, fish.Width, fish.Height);
                    fish.turn = false;
                }
                else
                {
                    if (Christmas)
                        g.DrawImage(rightd, fish.X, fish.Y, fish.Width, fish.Height);
                    else
                        g.DrawImage(rightdie, fish.X, fish.Y, fish.Width, fish.Height);
                }
            }
            else
            {
                if (fish.health != 0)
                {
                    if (Christmas)
                        g.DrawImage(leftf, fish.X, fish.Y, fish.Width, fish.Height);
                    else
                        g.DrawImage(leftfish, fish.X, fish.Y, fish.Width, fish.Height);
                }
                else
                {
                    if (Christmas)
                        g.DrawImage(leftd, fish.X, fish.Y, fish.Width, fish.Height);
                    else
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
                    if (Christmas)
                        g.DrawImage(rights, snail.X, snail.Y, snail.Width, snail.Height);
                    else
                        g.DrawImage(rightsnail, snail.X, snail.Y, snail.Width, snail.Height);
                    snail.turn = false;
                }
                else
                {
                    if (Christmas)
                        g.DrawImage(rightds, snail.X, snail.Y, snail.Width, snail.Height);
                    else
                        g.DrawImage(rightdiesnail, snail.X, snail.Y, snail.Width, snail.Height);
                }
            }
            else
            {
                if (snail.health != 0)
                {
                    if (Christmas)
                        g.DrawImage(lefts, snail.X, snail.Y, 150, 95);
                    else
                        g.DrawImage(leftsnail, snail.X, snail.Y, 150, 95);
                }
                else
                {
                    if (Christmas)
                        g.DrawImage(leftds, snail.X, snail.Y, snail.Width, snail.Height);
                    else
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

        public void DrawFood(List<Objects.Food> eda)
        {
            //foreach (Objects.Food food in eda)
            for (int i = 0; i < eda.Count(); i++)
                g.DrawImage(food, eda[i].X, eda[i].Y, 12, 12);
        }

        public void DrawWaterWood(List<Objects.WaterWood> vodrosblya)
        {
            foreach (Objects.WaterWood ww in vodrosblya)
            {
                int y = ww.Y;
                for (int i = 0; i < ww.height.Count; i++)
                {
                    g.DrawImage(waterwood, ww.X, y, 100, 80);
                    y -= 20;
                }
            }
        }
    }
}
