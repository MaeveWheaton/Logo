using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush blueBrush = new SolidBrush(Color.SteelBlue);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Font titleFont = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            
            //left red square
            g.TranslateTransform(100, 100);
            g.RotateTransform(135);
            g.FillRectangle(redBrush, 0, 0, 50, 50);
            g.ResetTransform();

            //Right red square
            g.TranslateTransform(138, 63);
            g.RotateTransform(135);
            g.FillRectangle(redBrush, 0, 0, 50, 50);
            g.ResetTransform();

            //blue rectangle
            g.TranslateTransform(176, 101);
            g.RotateTransform(135);
            g.FillRectangle(blueBrush, 0, 0, 103, 50);
            g.ResetTransform();

            //text
            g.TranslateTransform(68, 140);
            g.RotateTransform(315);
            g.DrawString("Domino's\nPizza", titleFont, whiteBrush, 0, 0);
            g.ResetTransform();

            //left two dots
            g.FillEllipse(whiteBrush,  42, 92, 16, 16);
            g.FillEllipse(whiteBrush, 68, 92, 16, 16);

            //right dot
            g.FillEllipse(whiteBrush, 94, 56, 16, 16);
        }
    }
}
