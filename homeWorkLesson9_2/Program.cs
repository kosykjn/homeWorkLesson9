using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();
            player.Play();
            player.Record();

            Console.ReadKey();
        }
    }
}
