using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miner
{
    
    public partial class Form1 : Form
    {
        int Cols {get; set;}
        int Rows { get; set; }
        int Mines { get; set; }
        int buttonDim = 30;
        int OpenCells;
        bool isStart;
        TimeSpan dt;
        DateTime startTime;
        IndexButton[,] ibutton;

        public Form1()
        {
            InitializeComponent();
            StartGame();
        }
        
        private void buttonClick(object sender, EventArgs e)
        {
            OpenCells++;
            if (!isStart)
            {
                startTime = DateTime.Now;
                timer1.Enabled = true;
            }
            isStart = true;
            string s = ((sender as IndexButton).Tag as string);
            (sender as IndexButton).Text = s;
            (sender as IndexButton).Enabled = false;
            if (s == "0")
            {
                string[] name = (sender as IndexButton).Name.Split(' ');
                CheckZerro(Int32.Parse(name[1]), Int32.Parse(name[2]));
                (sender as IndexButton).Text = "";
                (sender as IndexButton).Enabled = false;
            }
            if (s == "b" || (OpenCells + Mines >= Rows * Cols))
            {
                string mb ; 
                if (s == "b")
                    mb = "You lose!!! Start new game?";
                else
                    mb = "You win!!! Start new game?";
                NewGame();
                if (MessageBox.Show(mb, "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    StartGame();
                }
                else
                {
                    Avtosave.Checked = false;
                    Application.Exit();
                }
            }
            //this.Text = ((Rows * Cols) - (OpenCells + Mines)).ToString();
        }
        private void buttonRightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if ((sender as Button).Text == "b")
                {
                    (sender as Button).Text = "";
                    (sender as Button).ForeColor = Color.Black;
                    (sender as Button).Click += new System.EventHandler(this.buttonClick);
                }
                else
                {
                    (sender as Button).Text = "b";
                    (sender as Button).ForeColor = Color.Red;
                    (sender as Button).Click -= new System.EventHandler(this.buttonClick);
                }
            }
        }
        private void Form1Closed(object sender, FormClosedEventArgs e)
        {
            if (Avtosave.Checked) Serialize();
            else File.Delete("DataFile.dat");
        }
        private void buttonLevel_Click(object sender, EventArgs e)
        {
            FormSetLevel dform = new FormSetLevel() { Cols = this.Cols, Rows = this.Rows, Mines = this.Mines };
            if (dform.ShowDialog() == DialogResult.Yes)
            {
                this.Cols = dform.Cols;
                this.Rows = dform.Rows;
                this.Mines = dform.Mines;
                NewGame();
                StartGame();
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
            dt = DateTime.Now - startTime;
            if (isStart) label1.Text = ((TimeSpan)(DateTime.Now - startTime)).ToString();
        }
        private String[,] AddMines()
        {
            Random r = new Random();
            String[,] sbuttons = new string[Cols, Rows];


            for (int i = 0; i < Mines; i++)
            {
                int x = r.Next(Cols - 1);
                int y = r.Next(Rows - 1);
                sbuttons[x, y] = "b";
            }
            for (int i = 0; i < Cols; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    int Count = 0;
                    if (sbuttons[i, j] != "b")
                    {
                        if (i > 0)
                        {
                            if (sbuttons[i - 1, j] == "b") Count++;
                            if (j > 0)
                            {
                                if (sbuttons[i - 1, j - 1] == "b") Count++;
                            }
                            if (j < Rows - 1)
                            {
                                if (sbuttons[i - 1, j + 1] == "b") Count++;
                            }
                        }
                        if (i < Cols - 1)
                        {
                            if (sbuttons[i + 1, j] == "b") Count++;
                            if (j > 0)
                            {
                                if (sbuttons[i + 1, j - 1] == "b") Count++;
                            }
                            if (j < Rows - 1)
                            {
                                if (sbuttons[i + 1, j + 1] == "b") Count++;
                            }
                        }
                        if (j > 0) 
                            if (sbuttons[i, j - 1] == "b")
                                 Count++;
                        if (j < Rows - 1 && sbuttons[i, j + 1] == "b") 
                                Count++;
                        sbuttons[i, j] = Count.ToString();
                    }
                }
            }
            return sbuttons;
        }
        private IndexButton[,] CreateButtons(String[,] sMines, int ButtonDim)
        {
            IndexButton[,] buttons = new IndexButton[Cols, Rows];
            for (int i = 0; i < Cols; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    buttons[i,j] = new IndexButton(i, j);
                    buttons[i,j].Location = new System.Drawing.Point(i * buttonDim, j * buttonDim + 40);
                    buttons[i,j].Name = "b " + i.ToString() + " " + j.ToString();
                    buttons[i,j].Size = new System.Drawing.Size(buttonDim, buttonDim);
                    buttons[i,j].Text = "";
                    buttons[i,j].Tag = sMines[i, j]; ;
                    buttons[i,j].UseVisualStyleBackColor = true;
                    buttons[i,j].Click += new System.EventHandler(this.buttonClick);
                    buttons[i,j].MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonRightClick);
                }

            }
            return buttons;
        }
        private Control OpenTagButton(int x, int y)
        {
            Control c = this.ibutton[x, y];
            if (c.Enabled)
            {
                OpenCells++;
                this.Text = ((Rows * Cols) - (OpenCells + Mines)).ToString();
                c.Text = (c.Tag as string);
            }
            c.Enabled = false;
            return c;
        }
        private void Serialize()
        {
            FileStream fs = new FileStream("DataFile.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            SettingsMineForm f = new SettingsMineForm(Cols, Rows, Mines, OpenCells, isStart, dt, ibutton);
            try 
            { 
                formatter.Serialize(fs, f); 
            }
            catch (SerializationException e)
            {
                Debug.WriteLine("");
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally { 
                fs.Close(); 
            }

        }
        private void Deserialize()
        {

                FileStream fs = new FileStream("DataFile.dat", FileMode.Open);
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    SettingsMineForm f = (SettingsMineForm)formatter.Deserialize(fs);
                    ibutton = f.b;
                    Cols = f.Cols;
                    Rows = f.Rows;
                    Mines = f.Mines;
                    OpenCells = f.OpenCells;
                    isStart = f.isStart;
                    dt = f.dt;
                    startTime = DateTime.Now-dt;
                    foreach (var item in ibutton)
                    {
                        item.Click += new System.EventHandler(this.buttonClick);
                        item.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonRightClick);
                        if (item.ForeColor==Color.Red) 
                            item.Click -= new System.EventHandler(this.buttonClick);
                    }
                    
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                    throw;
                }
                finally
                {
                    fs.Close();
                }
 
        }
        private void CheckZerro(int x, int y)
        {
            if (x > 0)
            {
                if (OpenTagButton(x - 1, y).Text == "0")
                {
                    OpenTagButton(x - 1, y).Text = "";
                    CheckZerro(x - 1, y);
                }

                if (y > 0)
                {
                    if (OpenTagButton(x - 1, y - 1).Text == "0")
                    {
                        OpenTagButton(x - 1, y - 1).Text = "";
                        CheckZerro(x - 1, y - 1);
                    }
                }
                if (y < Rows - 1)
                {
                    if (OpenTagButton(x - 1, y + 1).Text == "0")
                    {
                        OpenTagButton(x - 1, y + 1).Text = "";
                        CheckZerro(x - 1, y + 1);
                    }
                }
            }
            if (x < Cols - 1)
            {
                if (OpenTagButton(x + 1, y).Text == "0")
                {
                    OpenTagButton(x + 1, y).Text = "";
                    CheckZerro(x + 1, y);
                }
                if (y > 0)
                {
                    if (OpenTagButton(x + 1, y - 1).Text == "0")
                    {
                        OpenTagButton(x + 1, y - 1).Text = "";
                        CheckZerro(x + 1, y - 1);
                    }
                }
                if (y < Rows - 1)
                {
                    if (OpenTagButton(x + 1, y + 1).Text == "0")
                    {
                        OpenTagButton(x + 1, y + 1).Text = "";
                        CheckZerro(x + 1, y + 1);
                    }
                }
            }
            if (y > 0)
            {
                if (OpenTagButton(x, y - 1).Text == "0")
                {
                    OpenTagButton(x, y - 1).Text = "";
                    CheckZerro(x, y - 1);
                }
            }
            if (y < Rows - 1)
            {
                if (OpenTagButton(x, y + 1).Text == "0")
                {
                    OpenTagButton(x, y + 1).Text = "";
                    CheckZerro(x, y + 1);
                }
            }
        }
        private void StartGame()
        {

            if (ibutton != null)
            {
                for (int i = 0; i < ibutton.GetLength(0); i++)
                {
                    for (int j = 0; j < ibutton.GetLength(1); j++)
                    {
                        this.Controls.Remove(ibutton[i, j]);
                    }
                }
                ibutton = null;
            }
            if (File.Exists("DataFile.dat"))
            {
                Deserialize();
            }
            else
            {
                if (Mines == 0)
                {
                    Cols = 12;
                    Rows = 12;
                    Mines = 10;
                    OpenCells = 0;
                }
                ibutton = CreateButtons(AddMines(), buttonDim);
            }
            this.Size = new System.Drawing.Size((buttonDim + 1) * Cols, (buttonDim + 1) * Rows + 62);
            for (int i = 0; i < ibutton.GetLength(0); i++)
            {
                for (int j = 0; j < ibutton.GetLength(1); j++)
                {
                    this.Controls.Add(ibutton[i, j]);
                }
            }
        }
        private void NewGame()
        {
            OpenCells = 0;
            dt = new TimeSpan(0);
            isStart = false;
            timer1.Enabled = false;
            label1.Text = "00:00:00:0000";
            File.Delete("DataFile.dat");
        }
    }

}
