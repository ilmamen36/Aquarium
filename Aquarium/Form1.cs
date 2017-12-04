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
            //label1.Visible = false;
            label1.Left = Screen.PrimaryScreen.Bounds.Size.Width - 170;
            label1.Top = 50; 
        }
        Aquarium world;
        Drawing draw;
        Form2 temperature = new Form2();
        bool fishFlag, foodFlag, snailFlag;
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
                timer2.Enabled = true;
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            x = MousePosition.X;
            y = MousePosition.Y;
            if (y <= 630)
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
            if (snailCount == 3)
            {
                улиткуToolStripMenuItem.Text = "Больше нельзя ;(";
                улиткуToolStripMenuItem.Enabled = false;
            }
            if (snailCount == 1)
                timer2.Enabled = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.Location.ToString();
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
        }

        

        private void регулировкаТемпературыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //temperature = new Form2();
            temperature.Show();
            //float temper = temperature.Temperature;
            //expl = "Температура : " + temper.ToString() + " °C";
            temperature.SetTemper(label1);
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
        }

        private void включитьАквариумToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foodFlag = true;
            bmp = new Bitmap(Width, Height);
            g = Graphics.FromImage(bmp);
            g.DrawImage(Image.FromFile("background.png"), 0, 0);
            BackgroundImage = bmp;
            world = new Aquarium();
            timer1.Enabled = true;
            включитьАквариумToolStripMenuItem.Enabled = false;
            добавитьРыбуToolStripMenuItem.Enabled = true;
            draw = new Drawing();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            world.AllFish.SlowDie();
            world.Temperature = temperature.Temperature;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (world.something.Korm.Count() !=0)
            {
                world.FoodExist();
                world.FallFood();
                world.RemoveFood();
            }
            world.AllFish.Move();            
            BackgroundImage = draw.DrawAll(world);
        }
    }
}
