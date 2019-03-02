using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.Clear(Color.FromArgb(255, 61, 76, 197));
            Pen p = new Pen(Color.Black, 10);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush redBrush = new SolidBrush(Color.FromArgb(255, 219, 55, 50));
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush greenBrush = new SolidBrush(Color.FromArgb(255, 85, 173, 88));
            Rectangle r = new Rectangle(419, 243, 16, 21);
            Rectangle border = new Rectangle(1, 1, 720, 450);
            g.DrawRectangle(p, border);

            //Drawing White Circles
            e.Graphics.FillEllipse(whiteBrush, 70, 100, 26, 26);
            e.Graphics.FillEllipse(whiteBrush, 320, 70, 26, 26);
            e.Graphics.FillEllipse(whiteBrush, 500, 120, 26, 26);
            e.Graphics.FillEllipse(whiteBrush, 725, 205, 26, 26);
            e.Graphics.FillEllipse(whiteBrush, 650, 300, 26, 26);
            e.Graphics.FillEllipse(whiteBrush, 725, 450, 26, 26);
            e.Graphics.FillEllipse(whiteBrush, 325, 365, 26, 26);
            e.Graphics.FillEllipse(whiteBrush, 80, 390, 26, 26);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            Point[] asteroid1 = {
                new Point(180, 150),
                new Point(187, 161),
                new Point(203, 161),
                new Point(195, 173),
                new Point(203, 185),
                new Point(187, 184),
                new Point(180, 196),
                new Point(170, 184),
                new Point(154, 184),
                new Point(161, 174),
                new Point(154, 161),
                new Point(169, 161),
            };

            Point[] asteroid2 = {
                new Point(647, 148),
                new Point(654, 159),
                new Point(670, 159),
                new Point(662, 171),
                new Point(670, 183),
                new Point(654, 182),
                new Point(647, 194),
                new Point(637, 182),
                new Point(621, 182),
                new Point(628, 172),
                new Point(621, 159),
                new Point(636, 159),
            };

            Point[] asteroid3 = {
                new Point(229, 285),
                new Point(236, 161+135),
                new Point(203+49, 161+135),
                new Point(195+49, 173+135),
                new Point(203+49, 185+135),
                new Point(187+49, 184+135),
                new Point(180+49, 196+135),
                new Point(170+49, 184+135),
                new Point(154+49, 184+135),
                new Point(161+49, 174+135),
                new Point(154+49, 161+135),
                new Point(169+49, 161+135),
            };

            Point[] asteroid4 = {
                new Point(545, 357),
                new Point(236+316, 161+135+72),
                new Point(203+49+316, 161+135+72),
                new Point(195+49+316, 173+135+72),
                new Point(203+49+316, 185+135+72),
                new Point(187+49+316, 184+135+72),
                new Point(180+49+316, 196+135+72),
                new Point(170+49+316, 184+135+72),
                new Point(154+49+316, 184+135+72),
                new Point(161+49+316, 174+135+72),
                new Point(154+49+316, 161+135+72),
                new Point(169+49+316, 161+135+72),
            };

            e.Graphics.FillPolygon(redBrush, asteroid1);
            e.Graphics.FillPolygon(redBrush, asteroid2);
            e.Graphics.FillPolygon(redBrush, asteroid3);
            e.Graphics.FillPolygon(redBrush, asteroid4);

            Point[] spaceship = {
                new Point(374, 221),
                new Point (374, 266),
                new Point (428, 289),
                new Point (479, 266),
                new Point (479, 221),
                new Point (428, 199)
            };

            e.Graphics.FillPolygon(yellowBrush, spaceship);

            Point[] gun1 = {
                new Point(412, 243),
                new Point (427, 221),
                new Point (442, 243)
            };

            e.Graphics.FillPolygon(greenBrush, gun1);
            e.Graphics.FillRectangle(greenBrush, r);

            Point[] bullet = {
                new Point(440, 160),
                new Point (445, 170),
                new Point (457, 174),
                new Point (445, 177),
                new Point (440, 188),
                new Point (435, 177),
                new Point (423, 174),
                new Point (435, 170)
            };

            e.Graphics.FillPolygon(greenBrush, bullet);

            /*string text1 = "Level: 1 Score: 200 Live:***";
            using (Font font1 = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit))
            {
                Rectangle label = new Rectangle (518, 23, 195, 30);
                e.Graphics.DrawString(text1, font1, Brushes.Black, label);
                e.Graphics.FillRectangle(whiteBrush, label);
            }*/

            Pen pen = new Pen(Color.Yellow, 3);
            PointF location = new PointF(518, 23);
            string text = "Level: 1 Score: 200 Live: ***";
            Font font = new Font("Arial", 11, FontStyle.Regular, GraphicsUnit.Point);
            Rectangle label = new Rectangle(518, 18, 195, 30);
            g.FillRectangle(whiteBrush, label);
            g.DrawRectangle(pen, label);
            g.DrawString(text, font, Brushes.Black, location);

            //e.Graphics.DrawLines(p, points);

            /*g.DrawEllipse(p, r);
            g.FillEllipse(solidBrush, 60, 80, 24, 24);*/
        }
    }
}
