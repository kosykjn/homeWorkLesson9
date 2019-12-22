using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Война и мир");
            Book book2 = new Book("Мастер и Маргарита");
            Book book3 = new Book("Старик и море");
            Magazine magazine1 = new Magazine("Forbes");
            Magazine magazine2 = new Magazine("Maxim");
            Magazine magazine3 = new Magazine("Космополитан");

            IPrintable[] printables = {
            book1,
            book2,
            book3,
            magazine1,
            magazine2,
            magazine3
            };

            Shop shop = new Shop(printables);
            shop.PrintMagazines();

            Console.ReadKey();
        }
    }

    
}
