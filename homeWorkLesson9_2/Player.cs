using System;

namespace homeWorkLesson9_2
{
    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Идет проигрывание...");
        }

        public void Record()
        {
            Console.WriteLine("Идет запись...");
        }
        public void Pause()
        {
            Console.WriteLine("Пауза...");
        }

        public void Stop()
        {
            Console.WriteLine("Остановлен...");
        }
    }
}
