using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchScreen
{
    public class ToochSCREventArgs: EventArgs
    {
        public Point point { get; set; }
        public LineDirection Diection { get; set; }
    }
}
