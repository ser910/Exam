using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkers
{
    public partial class Form1 : Form
    {
        List<PaintButton> whiteCheckers = new List<PaintButton>();
        List<PaintButton> blackCheckers = new List<PaintButton>();
        PaintButton movedChecer;
        Point startPos;
        public Form1()
        {
            InitializeComponent();
            this.DragOver += blackfieldDragOver;
            this.DragDrop += blackfield_DragDrop;
            AddCheckers();
            CreateField();
        }

        private void AddCheckers()
        {
            int cell = GetDim();
            int shift = 1;
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    PaintButton b1 = new PaintButton();
                    PaintButton b2 = new PaintButton();
                    b1.Location = new Point((2 * i + shift) * cell + 1, j * cell + 1);
                    b2.Location = new Point((2 * i + (1 - shift)) * cell + 1, (7 - j) * cell + 1);
                    b1.Size = new Size(cell-2, cell-2);
                    b2.Size = b1.Size;
                    b1.BackColor = Color.Ivory;
                    b2.BackColor = Color.SlateGray;
                    b1.MouseMove += paintButtonMouseMove;
                    b1.MouseDown += paintButtonMouseDown;
                    b1.MouseUp += b1_MouseUp;
                    b2.MouseMove += paintButtonMouseMove;
                    whiteCheckers.Add(b1);
                    blackCheckers.Add(b2);

                }
                shift = (shift == 1)?0:1;
            }
            this.Controls.AddRange(whiteCheckers.ToArray());
            this.Controls.AddRange(blackCheckers.ToArray());
        }

        void b1_MouseUp(object sender, MouseEventArgs e)
        {
            //startPos = new;
            //movedChecer.Visible = true;
        }

        void paintButtonMouseDown(object sender, MouseEventArgs e)
        {
            startPos = (sender as PaintButton).PointToScreen(new Point(e.X, e.Y));
            int i = 0;
        }

        private void CreateField()
        {
            bool Fieldcolor = false;
            int cell = GetDim();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button b = new Button();
                    b.Location = new Point(cell*i, cell*j);
                    b.Size = new Size(cell, cell);
                    Fieldcolor = !Fieldcolor;
                    if (Fieldcolor)
                        b.BackColor = Color.White;
                    else
                    {
                        b.BackColor = Color.Black;
                        //b.AllowDrop = true;
                        //b.DragOver += blackfieldDragOver;
                        //b.DragDrop += blackfield_DragDrop;
                    }
                    b.Enabled = false;
                    this.Controls.Add(b);
                }
                Fieldcolor = !Fieldcolor;
            }
        }
        private void blackfield_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PaintButton)))
            {
                PaintButton item = (PaintButton)e.Data.GetData(typeof(PaintButton));
                if (e.Effect == DragDropEffects.Move)
                {
                    Point p = new Point(e.X, e.Y);
                    item.Location = p;
                }
            }
        }
        private void blackfieldDragOver(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
            {
                e.Effect = DragDropEffects.Move;
            }
            else
                e.Effect = DragDropEffects.None;
            Point p = new Point(e.X, e.Y);
            movedChecer = (PaintButton)e.Data.GetData(typeof(PaintButton));
            //movedChecer.Visible = false;
            movedChecer.Location = p;
        }
        private int GetDim()
        {
            int FieldDim = (int)Math.Min(this.ClientSize.Height, this.ClientSize.Width);
            return FieldDim / 8;
        }
        private void paintButtonMouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                DragDropEffects dropEffect = this.DoDragDrop(sender as PaintButton, DragDropEffects.Move);
            }
        }
    }
}
