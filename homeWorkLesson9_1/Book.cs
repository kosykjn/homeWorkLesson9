using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson9_1
{
    class Book : IPrintable
    {
        public string Name { get; set; }
        public string Type = "Книга";

        public void Print()
        {
            Console.WriteLine($"{Type}: {Name}");
        }

        public Book (string name)
        {
            Name = name;
        }
    }
}
