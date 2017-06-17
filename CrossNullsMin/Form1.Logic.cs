using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Windows.Forms;
using System.IO;

namespace CrossNullsMin
{
    partial class Form1
    {
        private BitVector32 buttonsStates;
        private BitVector32.Section[] b;
        private bool Player = false;
        static int[] win = { 21, 1344, 4161, 4368, 16644, 65793, 66576, 86016 };
        enum Plr { X=1, O };
        private void CreateButtons()
        {
            buttonsStates = new BitVector32(0);
            b = new BitVector32.Section[9];
            b[0] = BitVector32.CreateSection(3);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button TMPbutton = new Button();
                    if ((i*3 + j) != 0)
                        b[i*3 + j] = BitVector32.CreateSection(3, b[i*3 + j - 1]);
                    TMPbutton.Location = new System.Drawing.Point(10 + bSize * j, 10 + bSize * i);
                    TMPbutton.Size = btnSize;
                    TMPbutton.Text = "";
                    TMPbutton.Tag = i*3 + j;
                    TMPbutton.Name = "b";
                    TMPbutton.Click += new System.EventHandler(buttonPlay);
                    this.Controls.Add(TMPbutton);
                }
            }
        }
        private void SaveButtons()
        {
            if (!Directory.Exists(@"d:\Temp")) Directory.CreateDirectory(@"d:\Temp");
            string file = Path.Combine(@"D:\Temp", "4.byte");
            FileStream fs = File.Create(file);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(buttonsStates.Data);
            bw.Dispose();
            fs.Close();
            fs.Dispose();
        }
        private void LoadButtons()
        {
            if (Directory.Exists(@"d:\Temp"))
            {
                string file = Path.Combine(@"D:\Temp", "4.byte");
                try
                {
                    FileStream fs = File.OpenRead(file);
                    BinaryReader br = new BinaryReader(fs);
                    buttonsStates = new BitVector32(br.ReadInt32());
                    Button[] btns = this.Controls.Find("b", false) as Button[];
                    foreach (Button btn in btns)
                    {
                        btn.Text = Enum.GetName(typeof(Plr), buttonsStates[b[Convert.ToInt32(btn.Tag)]]);
                        if (btn.Text != "") btn.Enabled = false;
                    }
                    br.Dispose();
                    fs.Close();
                    fs.Dispose();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                
            }
            else
                MessageBox.Show("Нет директории");
        }
        private void NewButtons()
        {
            foreach (Button btn in this.Controls.Find("b", false))
                this.Controls.Remove(btn);
            CreateButtons();
            Player = false;
            buttonsStates = new BitVector32(0);
        }
        private string Turn(Button btn)
        {
            String PlayerNum;
            Player = !Player;
            if (Player)
            {
                btn.Text = "X";
                btn.Enabled = false;
                buttonsStates[b[(int)btn.Tag]] = 1;
                PlayerNum = "Player2 turn";
            }
            else
            {
                btn.Text = "O";
                btn.Enabled = false;
                buttonsStates[b[(int)btn.Tag]] = 2;
                PlayerNum = "Player1 turn";
            }
            CheckWin(Player);
            return PlayerNum;
        }
        private void CheckWin(bool Player)
        {
            int k = ((Player)?1:2);
            for (int i = 0; i < win.Length; i++)
            {
                if ((k*win[i]&buttonsStates.Data) == k*win[i])
                    MessageBox.Show(String.Format("Player {0} win",k));
            }
        }
    }
}
