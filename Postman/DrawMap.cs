using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Postman
{
    class DrawMap
    {
        public Bitmap bitmap;
        public Graphics g;
        public PictureBox pbMap;
        //CreateMap cr = new CreateMap();
        int[,] point = new int[2,150];
       
        public void drawBuild(int[,] point)
        {
            g.Clear(Color.White);
            
            for (int i = 0; i < 150; i++)
            {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                Rectangle Rect = new Rectangle(point[0, i], point[1, i], 40, 15);
                g.FillRectangle(Brushes.DarkGreen, Rect);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                g.DrawString("д. "+(i+1), new Font("Times", 7), Brushes.White, Rect, sf);
             }
            pbMap.Image = bitmap;

        }

        public void drawWay(List<int[]> point, int[,] bild,bool redraw, int bag)
        {
            if(redraw)
                drawBuild(bild);
            for (int i = 0;i < Math.Min(bag, point.Count-1);i++)
                g.DrawLine( new Pen(Color.Blue, 1), point[i][0], point[i][1], point[i+1][0], point[i + 1][1]);

            g.DrawLine(new Pen(Color.Blue, 1), point[0][0], point[0][1], point[Math.Min(bag, point.Count - 1)][0], point[Math.Min(bag, point.Count - 1)][1]);

            pbMap.Image = bitmap;
        }
    }
}
