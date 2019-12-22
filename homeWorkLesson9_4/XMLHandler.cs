using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson9_4
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открываем документ типа XML...");
        }

        public override void Create()
        {
            Console.WriteLine("Создаем документ типа XML...");
        }

        public override void Change()
        {
            Console.WriteLine("Изменяем документ типа XML...");
        }

        public override void Save()
        {
            Console.WriteLine("Сохраняем документ типа XML...");
        }
    }
}
