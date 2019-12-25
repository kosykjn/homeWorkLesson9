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
            IRecordable player1 = new Player();
            player1.Record();
            player1.Pause();
            player1.Stop();

            IPlayable player2 = new Player();
            player2.Play();
            player2.Pause();
            player2.Stop();

            Console.ReadKey();
        }
    }
}
