using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    class ToolStripListBox : ToolStripControlHost
    {
        public ToolStripListBox() : base (new ListBox()) 
        {}
        public ListBox ListBoxControl
        {
            get 
            {
                return Control as ListBox;
            }
        }
    }
}
