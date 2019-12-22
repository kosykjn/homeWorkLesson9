using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson9_3
{
    class ConcreteDocument : Document
    {   
        public override void Headline()
        {
            Console.WriteLine("Заголовок документа");
        }
        public override void DocumentСontent()
        {
            Console.WriteLine("Содержимое документа");
        }
        public override void Footer()
        {
            Console.WriteLine("Концовка документа");
        }
    }
}
