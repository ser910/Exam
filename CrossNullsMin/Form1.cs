using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrossNullsMin
{
    public partial class Form1 : Form
    {
        const int bSize = 64;
        Size btnSize = new System.Drawing.Size(bSize, bSize);
        public Form1()
        {
            InitializeComponent();
            CreateButtons();
        }
        private void button_Save(object sender, EventArgs e)
        {
            SaveButtons();
        }
        private void button_Load(object sender, EventArgs e)
        {
            LoadButtons();
        }
        private void buttonPlay(object sender, EventArgs e)
        {
            
            this.Text = Turn(sender as Button);
        }
        private void button_New(object sender, EventArgs e)
        {
            NewButtons();
        }

        
    }
}
