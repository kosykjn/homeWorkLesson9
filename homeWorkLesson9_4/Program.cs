using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DOCHandler dOCHandler = new DOCHandler();
            dOCHandler.Create();
            dOCHandler.Open();
            dOCHandler.Change();
            dOCHandler.Save();

            TXTHandler tXTHandler = new TXTHandler();
            tXTHandler.Create();
            tXTHandler.Open();
            tXTHandler.Change();
            tXTHandler.Save();

            XMLHandler xMLHandler = new XMLHandler();
            xMLHandler.Create();
            xMLHandler.Open();
            xMLHandler.Change();
            xMLHandler.Save();

            Console.ReadKey();
        }
    }
}
