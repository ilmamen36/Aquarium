using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquarium2
{
    public partial class Form2 : Form
    {
        public Form2(int temp)
        {
            InitializeComponent();
            trackBar1.Value = temp;
        }
        Label lab;
        public float Temperature { get; set; } = 20;
        

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Temperature = (float)trackBar1.Value / 10;
            lab.Text = "Температура : " + Temperature.ToString() + " °C";
        }

        //public string AquaTempSet()
        //{
        //    string expl = lab.Text;
        //    if (expl.Contains("."))
        //    {
        //        return expl[14].ToString() + expl[15].ToString() + expl[16].ToString() + expl[17].ToString();
        //    }
        //    else
        //    {
        //        return expl[14].ToString() + expl[15].ToString();
        //    }
            
        //}

        public void SetTemper(Label lable)
        {
            lab = lable;
        }


    }
}
