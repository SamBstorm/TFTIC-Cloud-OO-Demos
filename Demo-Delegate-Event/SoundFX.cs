using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegate_Event
{
    internal static class SoundFX
    {
        public static void MakeNoise(object sender, GooseGameEventArgs args)
        {
            MakeNoise();
        }
        public static void MakeNoise()
        {
            Console.Beep(57, 1000);
        }
        public static void VictoryMusic(object sender, GooseGameEventArgs args)
        {
            VictoryMusic();
        }
        public static void VictoryMusic()
        {
            Console.Beep(128, 1000);
            Console.Beep(68, 1000);
            Console.Beep(74, 1000);
            Console.Beep(128, 1000);
            Console.Beep(68, 1000);
            Console.Beep(74, 1000);
            Console.Beep(128, 1000);
            Console.Beep(68, 1000);
            Console.Beep(74, 1000);
        }
    }
}
