using System;

namespace homeWorkLesson9_1
{
    class Shop : IPrintable 
    {
        public IPrintable[] PrintableItems { get; set; }

        public Shop(IPrintable[] printablesArray)
        {
            PrintableItems = printablesArray;
        }

        public void Print()
        {
            foreach (var printableItem in PrintableItems)
            {
                printableItem.Print();
            }
        }

        public void PrintBooks()
        {
            foreach (var printableItem in PrintableItems)
            {
                if (printableItem is Book)
                {
                    printableItem.Print();
                }              
            }
        }

        public void PrintMagazines()
        {
            foreach (var printableItem in PrintableItems)
            {
                if (printableItem is Magazine)
                {
                    printableItem.Print();
                }
            }
        }
    }
}
