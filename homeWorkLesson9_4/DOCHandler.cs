using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson9_4
{
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открываем документ типа DOC...");
        }

        public override void Create()
        {
            Console.WriteLine("Создаем документ типа DOC...");
        }

        public override void Change()
        {
            Console.WriteLine("Изменяем документ типа DOC...");
        }   
        
        public override void Save()
        {
            Console.WriteLine("Сохраняем документ типа DOC...");
        }
    }
}
