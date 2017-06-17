using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkers
{
    class PaintButton : Button
    {
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            Rectangle r = this.ClientRectangle;
            r.Inflate(-4, -4);
            GraphicsPath g = new GraphicsPath();
            g.AddEllipse(r);
            Region region = new Region(g);
            this.Region = region;
            pevent.Graphics.FillEllipse(new SolidBrush(this.BackColor), r);
            pevent.Graphics.DrawEllipse(new Pen(SystemColors.ActiveBorder), r);
            
        }


    }

}
