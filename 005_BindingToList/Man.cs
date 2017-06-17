using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindSourse
{
    class Man
    {
        public Man() { }
        public Man(string str)
        {
            Name = str;
        }
        public Man(string str, int iNum)
        {
            Name = str;
            Id = iNum;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        /*
        public override string ToString()
        {
            return String.Format("Man Name:{0} Id:{1}",Name,Id);
        }
        */
    }
}
