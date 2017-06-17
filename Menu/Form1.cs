using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        GameSettings s;
        public Form1()
        {
            InitializeComponent();
            s = new GameSettings(0, 45 * Math.PI / 180, Size.Subtract(this.ClientSize,this.paintButton1.Size));
            CreateToolStrip();
            
        }

        

        void ListBoxControl_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            s.speed = Convert.ToInt32((sender as ListBox).SelectedItem);
            
            
        }
        void AngleUpDown_Click(object sender, EventArgs e)
        {
            //s.angle = Convert.ToInt32((sender as ToolStripNumericUpDown).NumericUpDownControl.Text) * Math.PI / 180;
            Debug.Print("{0}", s.degreeAngle);
        }   
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startStopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.paintButton1.Move(ref s);
        }
        
        private void CreateToolStrip()
        {
            ToolStripNumericUpDown AngleUpDown = new ToolStripNumericUpDown();
            AngleUpDown.NumericUpDownControl.Minimum = -360;
            AngleUpDown.NumericUpDownControl.Maximum = 360;
            AngleUpDown.NumericUpDownControl.DataBindings.Add("Text", s, "degreeAngle");

            AngleUpDown.Click += AngleUpDown_Click;
            toolStripAngle.DropDownItems.Add(AngleUpDown);
            ToolStripListBox Speed = new ToolStripListBox();
            Speed.ListBoxControl.Items.Add("1"); 
            Speed.ListBoxControl.Items.Add("2");
            Speed.ListBoxControl.Items.Add("3");
            Speed.ListBoxControl.Items.Add("5");
            Speed.ListBoxControl.Items.Add("10");
            Speed.ListBoxControl.SelectedIndexChanged += ListBoxControl_SelectedIndexChanged;
            toolStripSpeed.DropDownItems.Add(Speed);
        }
    }
}
