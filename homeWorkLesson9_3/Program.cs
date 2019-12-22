using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteDocument concreteDocument = new ConcreteDocument();
            concreteDocument.Headline();
            concreteDocument.DocumentСontent();
            concreteDocument.Footer();

            Console.ReadKey();
        }
    }
}
