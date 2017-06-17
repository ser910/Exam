using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miner
{
    public partial class FormSetLevel : Form
    {
        public int Cols { get; set; }
        public int Rows { get; set; }
        public int Mines { get; set; }
        public FormSetLevel()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem as String)
            {
                case "Low":
                        Cols = 10;
                        Rows = 10;
                        Mines = 10;
                        break;
                case "Normal":
                        Cols = 15;
                        Rows = 15;
                        Mines = 20;
                        break;
                case "Hard" :
                    
                        Cols = 20;
                        Rows = 15;
                        Mines = 40;
                        break;
                default :
                        Cols = 12;
                        Rows = 12;
                        Mines = 10;
                        break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.Yes;
        }
    }
}
