using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Menu
{
    public class PaintButton : Button
    {
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            Rectangle r = this.ClientRectangle;
            GraphicsPath g = new GraphicsPath();
            g.AddEllipse(r);
            Region region = new Region(g);
            this.Region = region;
            r.Inflate(1, 1);
            pevent.Graphics.FillEllipse(Brushes.Red, r);
            r.Inflate(-1, -1);
            pevent.Graphics.DrawEllipse(Pens.Gray, r);
            pevent.Graphics.DrawString(this.Text, this.Font, Brushes.Black, r, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
        }
        public void Move(ref GameSettings s)
        {
            int x = s.X;
            int y = s.Y;
            this.Location = new Point(this.Location.X + x, this.Location.Y + y);
            if (this.Location.X >= s.Gamefield.Width)
            {
                s.angle = Math.PI - s.angle;
            }
            if (this.Location.X <= 0)
            {
                s.angle = - (Math.PI+s.angle);
            }
            if (this.Location.Y >= s.Gamefield.Width)
            {
                s.angle = - s.angle;
            }
            if (this.Location.Y <= 0)
            {
                s.angle = - s.angle;
            }
        }
    }

}
