using System;
using System.Threading;
using System.Media;
using System.Timers;

namespace consoleSoundPlayer
{
    class Program
    {
        // Массив с ёлочкой.
        public static string[] arraytree = { 
            "                         *\r\n", 
            "                       ****\r\n", 
            "                      *******\r\n", 
            "                     *********\r\n", 
            "                    ***********\r\n", 
            "                   *************\r\n", 
            "                  ***************\r\n", 
            "                 *****************\r\n", 
            "                *******************\r\n", 
            "               *********************\r\n", 
            "              ***********************\r\n", 
            "             *************************\r\n", 
            "                       ****\r\n", 
            "                       ****\r\n", 
            "                       ****\r\n"};

        static long longcounter = 0;
        
        static void Main(string[] args)
        {
            Console.Title = "Проигрователь. Нажмите любую клавишу для выхода...";
            Thread threadwsp = new Thread(new ThreadStart(WSoundPlayer));
            threadwsp.Start();
            Thread threadgarland = new Thread(new ThreadStart(GarlandTimer));
            threadgarland.Start();
        }

        // Метод для работы с Sound Player.
        public static void WSoundPlayer()
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = "C:\\Users\\ABM\\Downloads\\В-Лесу-Родилась-Ёлочка.wav";
            soundPlayer.Load();
            soundPlayer.PlayLooping();
            soundPlayer.Dispose();
        }

        // Метод для гирлянды.
        public static void ColorGarland(Object source, ElapsedEventArgs e)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;
            if (longcounter >= 0 && longcounter <= 10)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                for(int i = 0; i < arraytree.Length; i++)
                {
                    Console.Write(arraytree[i]);
                }
                longcounter++;
            }
            if (longcounter >= 11 && longcounter <= 20)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                for (int i = 0; i < arraytree.Length; i++)
                {
                    Console.Write(arraytree[i]);
                }
                longcounter++;
            }
            if (longcounter >= 21 && longcounter <= 30)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                for (int i = 0; i < arraytree.Length; i++)
                {
                    Console.Write(arraytree[i]);
                }
                longcounter++;
            }
            if (longcounter >= 31 && longcounter <= 40)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                for (int i = 0; i < arraytree.Length; i++)
                {
                    Console.Write(arraytree[i]);
                }
                longcounter++;
            }
            if (longcounter >= 41 && longcounter <= 50)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                for (int i = 0; i < arraytree.Length; i++)
                {
                    Console.Write(arraytree[i]);
                }
                longcounter++;
            }
            if (longcounter >= 51 && longcounter <= 60)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                for (int i = 0; i < arraytree.Length; i++)
                {
                    Console.Write(arraytree[i]);
                }
                longcounter = 0;
            }
        }

        // Метод для таймера.
        public static void GarlandTimer()
        {
            System.Timers.Timer timergarland = new System.Timers.Timer(400);
            timergarland.Elapsed += ColorGarland;
            timergarland.AutoReset = true;
            timergarland.Enabled = true;
            Console.ReadKey();
            timergarland.Stop();
            timergarland.Dispose();
        }
    }
}
