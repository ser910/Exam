using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miner
{
    [Serializable]
    public class IndexButton : Button, ISerializable
    {
        public int x;
        public int y;
        public IndexButton(int x, int y)
            : base()
        {
            this.x = x;
            this.y = y;
        }
        protected IndexButton(SerializationInfo SiButton, StreamingContext context)
        {
            this.x = SiButton.GetInt32("x");
            this.y = SiButton.GetInt32("y");
            base.Size = (Size)SiButton.GetValue("Size", typeof(Size));
            base.Location = (Point)SiButton.GetValue("Location", typeof(Point));
            base.Name = (String)SiButton.GetString("Name");
            base.Text = (String)SiButton.GetString("Text");
            base.Tag = (String)SiButton.GetString("Tag");
            base.Enabled = (Boolean)SiButton.GetBoolean("Enabled");
            base.ForeColor = (Color)SiButton.GetValue("ForeColor", typeof(Color));
        }

        [SecurityPermissionAttribute(SecurityAction.Demand,
        SerializationFormatter = true)]
        public void GetObjectData(SerializationInfo SiButton, StreamingContext context)
        {
            SiButton.AddValue("x", this.x);
            SiButton.AddValue("y", this.y);
            SiButton.AddValue("Size", base.Size, base.Size.GetType());
            SiButton.AddValue("Location", base.Location, base.Location.GetType());
            SiButton.AddValue("Name", base.Name, base.Name.GetType());
            SiButton.AddValue("Text", base.Text, base.Text.GetType());
            SiButton.AddValue("Tag", base.Tag, base.Tag.GetType());
            SiButton.AddValue("Enabled", base.Enabled, base.Enabled.GetType());
            SiButton.AddValue("ForeColor", base.ForeColor, base.ForeColor.GetType());
        }
    }
}
