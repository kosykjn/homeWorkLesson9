using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson9_1
{
    class Magazine : IPrintable
    {
        public string Name { get; set; }
        public string Type = "Журнал";


        public void Print()
        {
            Console.WriteLine($"{Type}: {Name}");
        }
        public Magazine (string name)
        {
            Name = name;
        }
    }
}
