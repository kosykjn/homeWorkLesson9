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
        void IRecordable.Pause()
        {
            Console.WriteLine("Пауза (записи)...");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("Остановка (записи)...");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Пауза (проигрывания)...");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Остановка (проигрывания)...");
        }
    }
}
