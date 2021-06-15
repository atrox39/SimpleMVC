using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVC.Base.Structs
{
    class Column
    {
        public string Name;
        public string Type;
        public int Size;
        public Column(string name, string type, int size)
        {
            Name = name; Type = type; Size = size;
        }
    }
}
