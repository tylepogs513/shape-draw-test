using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shape_draw_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int heroX1= 100;
        int heroY1= 100;
        int heroX2 = 200;
        int heroY2 = 200;
        int heroX3 = 300;
        int heroY3 = 300;
        int heroX4 = 400;
        int heroX5 = 500;
        int heroSize = 20;

        SolidBrush lBrush = new SolidBrush(Color.Orange);
        SolidBrush jBrush = new SolidBrush(Color.Blue);
        SolidBrush sBrush = new SolidBrush(Color.Green);
        SolidBrush zBrush = new SolidBrush(Color.Red);
        SolidBrush oBrush = new SolidBrush(Color.Yellow);
        SolidBrush tBrush = new SolidBrush(Color.Purple);
        Pen outlinePen = new Pen(Color.Black);



        private void Form1_Click(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            //L shape
                //up
                g.FillRectangle(lBrush, heroX1, heroY1, heroSize, heroSize);
                g.FillRectangle(lBrush, heroX1 + 20, heroY1, heroSize, heroSize);
                g.FillRectangle(lBrush, heroX1, heroY1 - 20, heroSize, heroSize);
                g.FillRectangle(lBrush, heroX1, heroY1 - 40, heroSize, heroSize);

                g.DrawRectangle(outlinePen, heroX1, heroY1, heroSize, heroSize);
                g.DrawRectangle(outlinePen, heroX1 + 20, heroY1, heroSize, heroSize);
                g.DrawRectangle(outlinePen, heroX1, heroY1 - 20, heroSize, heroSize);
                g.DrawRectangle(outlinePen, heroX1, heroY1 - 40, heroSize, heroSize);

            //backwards L shape
                //up
                g.FillRectangle(jBrush, heroX2, heroY2, heroSize, heroSize);
                g.FillRectangle(jBrush, heroX2 - 20, heroY2, heroSize, heroSize);
                g.FillRectangle(jBrush, heroX2, heroY2 - 20, heroSize, heroSize);
                g.FillRectangle(jBrush, heroX2, heroY2 - 40, heroSize, heroSize);

                g.DrawRectangle(outlinePen, heroX2, heroY2, heroSize, heroSize);
                g.DrawRectangle(outlinePen, heroX2 - 20, heroY2, heroSize, heroSize);
                g.DrawRectangle(outlinePen, heroX2, heroY2 - 20, heroSize, heroSize);
                g.DrawRectangle(outlinePen, heroX2, heroY2 - 40, heroSize, heroSize);
            //S shape
                //up
                g.FillRectangle(sBrush, heroX3, heroY3, heroSize, heroSize);
                g.FillRectangle(sBrush, heroX3 + 20, heroY3, heroSize, heroSize);
                g.FillRectangle(sBrush, heroX3, heroY3 - 20, heroSize, heroSize);
                g.FillRectangle(sBrush, heroX3 - 20, heroY3 - 20, heroSize, heroSize);

                g.DrawRectangle(outlinePen, heroX3, heroY3, heroSize, heroSize);
                g.DrawRectangle(outlinePen, heroX3 + 20, heroY3, heroSize, heroSize);
                g.DrawRectangle(outlinePen, heroX3, heroY3 - 20, heroSize, heroSize);
                g.DrawRectangle(outlinePen, heroX3 - 20, heroY3 - 20, heroSize, heroSize);

            //Z shape
                //up
            g.FillRectangle(zBrush, heroX3, heroY1, heroSize, heroSize);
            g.FillRectangle(zBrush, heroX3 - 20, heroY1, heroSize, heroSize);
            g.FillRectangle(zBrush, heroX3, heroY1 - 20, heroSize, heroSize);
            g.FillRectangle(zBrush, heroX3 + 20, heroY1 - 20, heroSize, heroSize);

            g.DrawRectangle(outlinePen, heroX3, heroY1, heroSize, heroSize);
            g.DrawRectangle(outlinePen, heroX3 - 20, heroY1, heroSize, heroSize);
            g.DrawRectangle(outlinePen, heroX3, heroY1 - 20, heroSize, heroSize);
            g.DrawRectangle(outlinePen, heroX3 + 20, heroY1 - 20, heroSize, heroSize);

            //O shape
                //up
            g.FillRectangle(oBrush, heroX4, heroY2, heroSize, heroSize);
            g.FillRectangle(oBrush, heroX4 + 20, heroY2, heroSize, heroSize);
            g.FillRectangle(oBrush, heroX4, heroY2 - 20, heroSize, heroSize);
            g.FillRectangle(oBrush, heroX4 + 20, heroY2 - 20, heroSize, heroSize);

            g.DrawRectangle(outlinePen, heroX4, heroY2, heroSize, heroSize);
            g.DrawRectangle(outlinePen, heroX4 + 20, heroY2, heroSize, heroSize);
            g.DrawRectangle(outlinePen, heroX4, heroY2 - 20, heroSize, heroSize);
            g.DrawRectangle(outlinePen, heroX4 + 20, heroY2 - 20, heroSize, heroSize);

            //T shape
                //up
            g.FillRectangle(tBrush, heroX5, heroY3, heroSize, heroSize);
            g.FillRectangle(tBrush, heroX5 + 20, heroY3, heroSize, heroSize);
            g.FillRectangle(tBrush, heroX5 - 20, heroY3, heroSize, heroSize);
            g.FillRectangle(tBrush, heroX5, heroY3 - 20, heroSize, heroSize);

            g.DrawRectangle(outlinePen, heroX5, heroY3, heroSize, heroSize);
            g.DrawRectangle(outlinePen, heroX5 + 20, heroY3, heroSize, heroSize);
            g.DrawRectangle(outlinePen, heroX5 - 20, heroY3, heroSize, heroSize);
            g.DrawRectangle(outlinePen, heroX5, heroY3 - 20, heroSize, heroSize);
        }
    }
}
