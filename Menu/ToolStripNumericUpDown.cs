using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    class ToolStripNumericUpDown : ToolStripControlHost
    {
        public ToolStripNumericUpDown() : base(new NumericUpDown()) 
        {
            
        }

        public NumericUpDown NumericUpDownControl
        {
            get 
            {
                return Control as NumericUpDown;
            }
        }

    }
}
