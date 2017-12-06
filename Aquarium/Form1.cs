using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace Aquarium2
{
    public partial class Aqua : Form
    {
        public Aqua()
        {
            InitializeComponent();
            label1.Visible = false;
            label1.Left = screenSizeW - 170;
            label1.Top = 50;
        }
        static Size resolution = Screen.PrimaryScreen.Bounds.Size;
        int screenSizeW = resolution.Width;
        Aquarium world;
        Drawing draw;
        Form2 temperature = new Form2(200);
        bool fishFlag, foodFlag, snailFlag, Christmas;
        Graphics g;
        static Bitmap bmp;
        int x, y;
        int bigFishCount = 0;
        int snailCount = 0;


        private void рыбуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fishFlag = true;
            bigFishCount++;
            рыбуToolStripMenuItem.Text = "Рыбу " + bigFishCount.ToString() + "/3";
            if (bigFishCount == 3)
            {
                рыбуToolStripMenuItem.Text = "Больше нельзя ;(";
                рыбуToolStripMenuItem.Enabled = false;
            }
            if (bigFishCount == 1)
                LifeTemp.Enabled = true;
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            x = MousePosition.X;
            y = MousePosition.Y;
            if (y <= 650)
            {
                if (!fishFlag && foodFlag)
                {
                    world.CreateFood(x, y);
                    world.FoodExist();
                }
                if (fishFlag)
                {
                    g.DrawImage(Image.FromFile("background.png"), 0, 0);
                    world.Add(new FishAdult(g, x, y));
                    BackgroundImage = bmp;
                    fishFlag = false;
                }
            }
            else
            {
                if (snailFlag)
                {
                    g.DrawImage(Image.FromFile("background.png"), 0, 0);
                    world.Add(new Snail(g, x, y));
                    BackgroundImage = bmp;
                    snailFlag = false;
                }
                else
                    snailCount--;
            }
        }

        private void улиткуToolStripMenuItem_Click(object sender, EventArgs e)
        {

            snailFlag = true;
            snailCount++;
            улиткуToolStripMenuItem.Text = "Улитку " + snailCount.ToString() + "/4";
            if (snailCount == 4)
            {
                улиткуToolStripMenuItem.Text = "Больше нельзя ;(";
                улиткуToolStripMenuItem.Enabled = false;
            }
            if (snailCount == 1)
                LifeTemp.Enabled = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = e.Location.ToString();
        }

        private void светВклвыклToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(Width, Height);
            g = Graphics.FromImage(bmp);

            if (draw.Light)
            {
                g.DrawImage(Image.FromFile("background.png"), 0, 0);

            }

            else
                g.DrawImage(Image.FromFile("background2.png"), 0, 0);
            BackgroundImage = bmp;
            draw.Light = !draw.Light;
            world.SetLight(draw.Light);
        }

        private void Temp()
        {
            string str;
            string expl = label1.Text;
            if (expl.Contains("."))
            {
                str = (expl[14].ToString() + expl[15].ToString() + expl[16].ToString() + expl[17].ToString()).ToString();
            }
            else
            {
                str = (expl[14].ToString() + expl[15].ToString()).ToString();
            }
            world.Temperature = float.Parse(str);
            //if (world.Temperature == 23 && !SexTime.Enabled)
            //    SexTime.Enabled = true;
        }

        private void регулировкаТемпературыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            temperature = new Form2((int)(world.Temperature * 10));
            //if (world.Temperature != 0)
            //    temperature.Temperature = world.Temperature;
            temperature.Show();
            //float temper = temperature.Temperature;
            //expl = "Температура : " + temper.ToString() + " °C";
            temperature.SetTemper(label1);
        }

        private void SexTime_Tick(object sender, EventArgs e)
        {
            world.sexflag = true;
            SexTime.Enabled = false;
        }

        private void GrowTime_Tick(object sender, EventArgs e)
        {
            world.GrowFish(g);
        }

        private void timeForGrowing_Tick(object sender, EventArgs e)
        {
            world.GrowWaterWood();
        }

        private void сюрпризToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Christmas)
            {
                Christmas = true;
                if (draw.Light)
                    g.DrawImage(Image.FromFile("backgroundChr.png"), 0, 0);
                else
                    g.DrawImage(Image.FromFile("background2Chr.png"), 0, 0);
                BackgroundImage = bmp;
                draw.Christmas = true;
            }
            else
            {
                Christmas = false;
                draw.Christmas = false;
            }
        }

        private void включитьАквариумToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            foodFlag = true;
            регулировкаТемпературыToolStripMenuItem.Enabled = true;
            сюрпризToolStripMenuItem.Enabled = true;
            bmp = new Bitmap(Width, Height);
            g = Graphics.FromImage(bmp);
            g.DrawImage(Image.FromFile("background.png"), 0, 0);
            BackgroundImage = bmp;
            world = new Aquarium();
            MoveFood.Enabled = true;
            включитьАквариумToolStripMenuItem.Enabled = false;
            добавитьРыбуToolStripMenuItem.Enabled = true;
            draw = new Drawing();
            timeForGrowing.Enabled = true;
        }

        private void LifeTemp_Tick(object sender, EventArgs e)
        {
            if (world.Temperature >= 21.5)
            {
                LifeTemp.Interval = 1000;
                MoveFood.Interval = 3;
            }
            else
            {
                LifeTemp.Interval = 200;
                MoveFood.Interval = 15;
            }
            world.AllFish.SlowDie();

        }

        private void MoveFood_Tick(object sender, EventArgs e)
        {
            world.FoodExist();
            if (world.something.Korm.Count() != 0)
            {
                world.FallFood();
                world.RemoveFood();
            }
            if (world.Temperature == 23 && world.sexflag)
                world.NormConditions(g);
            if (world.Temperature == 23 && !world.sexflag)
            {
                SexTime.Enabled = true;
                GrowTime.Enabled = true;
            }
            world.AllFish.Move();

            Temp();
            BackgroundImage = draw.DrawAll(world);
        }
    }
}
