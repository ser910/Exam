using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miner
{
    [Serializable]
    public class SettingsMineForm
    {
        public int Cols { get; set; }
        public int Rows { get; set; }
        public int Mines { get; set; }
        public int OpenCells;
        public bool isStart;
        public TimeSpan dt;
        public IndexButton[,] b;
        public SettingsMineForm(int Cols, int Rows, int Mines, int OpenCells, bool isStart, TimeSpan dt, IndexButton[,] b)
        {
            this.Cols = Cols;
            this.Rows = Rows;
            this.Mines = Mines;
            this.OpenCells = OpenCells;
            this.isStart = isStart;
            this.dt = dt;
            this.b = b;
        }

    }
}
