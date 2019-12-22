using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson9_4
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открываем документ типа TXT...");
        }

        public override void Create()
        {
            Console.WriteLine("Создаем документ типа TXT...");
        }

        public override void Change()
        {
            Console.WriteLine("Изменяем документ типа TXT...");
        }

        public override void Save()
        {
            Console.WriteLine("Сохраняем документ типа TXT...");
        }
    }
}
