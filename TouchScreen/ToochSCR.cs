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

namespace TouchScreen
{
    [Flags]
    public enum LineDirection
    {
        Up = 1,
        Down = 2,
        Left = 4,
        Right = 8
    }
    public partial class ToochSCR : UserControl
    {
        private LineDirection DiectionLine { get; set; }
        private Point _startline, _endline;
        public bool CMDLine
        {
            get
            {
                return this.statusStrip1.Visible;
            }
            set
            {
                this.statusStrip1.Visible = value;
            }
        }
        
        event EventHandler<ToochSCREventArgs> LineDraw;
        public ToochSCR()
        {
            InitializeComponent();
            if (!CMDLine)
                statusStrip1.Visible = false;
            else
                statusStrip1.Visible = true;
        }
        protected void OnLineDraw(ToochSCREventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(SystemColors.Control);
            Pen RedArrow = new Pen(Color.Red, 1);
            AdjustableArrowCap bigArrow = new AdjustableArrowCap(3, 3);
            RedArrow.CustomEndCap = bigArrow;//.ArrowAnchor;
            g.DrawLine(RedArrow, e.point, _endline);
            g.Dispose();
            if (CMDLine)
            {
                CMDLabel.Text = e.Diection.ToString();
            }
            if(LineDraw !=null)
            {
                LineDraw(this, e);
            }
        }

        private void ToochSCR_MouseDown(object sender, MouseEventArgs e)
        {
            _startline = e.Location; 
        }

        private void ToochSCR_MouseUp(object sender, MouseEventArgs e)
        {
            _endline = e.Location;
            if (_startline != _endline)
            {
                double x = _endline.X - _startline.X;
                double y = _endline.Y - _startline.Y;

                if (Math.Abs(x) / Math.Abs(y) > 1.5)
                {
                    if (x > 0)
                        DiectionLine = LineDirection.Right;
                    else 
                        DiectionLine = LineDirection.Left;
                }
                if (Math.Abs(x) / Math.Abs(y) < 0.75)
                {
                    if (y > 0)
                        DiectionLine = LineDirection.Down;
                    else
                        DiectionLine = LineDirection.Up;
                }
                if (Math.Abs(x) / Math.Abs(y) > 0.75 && Math.Abs(x) / Math.Abs(y) < 1.5)
                {
                    DiectionLine = 0;
                    if (x > 0)
                        DiectionLine |= LineDirection.Right;
                    else
                        DiectionLine |= LineDirection.Left;
                    if (y > 0)
                        DiectionLine |= LineDirection.Down;
                    else
                        DiectionLine |= LineDirection.Up;
                }
                OnLineDraw(new ToochSCREventArgs() {Diection = DiectionLine, point = _startline});
            }
        }
    }
}
