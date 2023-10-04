namespace шарп_пианино
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Переключение октав:f4,f5,f6,f7");
                ConsoleKeyInfo octave = Console.ReadKey();
                switch (octave.Key)
                {
                    case (ConsoleKey.F4):
                        int[] octave4 = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
                        Octave("4 октава", octave4);
                        break;
                    case (ConsoleKey.F5):
                        int[] octave5 = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
                        Octave("5 октава", octave5);
                        break;
                    case (ConsoleKey.F6):
                        int[] octave6 = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
                        Octave("6 октава", octave6);
                        break;
                    case (ConsoleKey.F7):
                        int[] octave7 = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
                        Octave("7 октава", octave7);
                        break;
                    case (ConsoleKey.Escape):
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Попробуйте нажать другую клавишу");
                        break;
                }
            }
        }
        static void sound(int x)
        {
            Console.Beep(x, 300);
        }
        static void Octave(string name, int[] octave)
        {
            while (true)
            {
                Console.WriteLine(name);
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.Q:
                        sound(octave[0]);
                        break;
                    case ConsoleKey.W:
                        sound(octave[1]);
                        break;
                    case ConsoleKey.E:
                        sound(octave[2]);
                        break;
                    case ConsoleKey.R:
                        sound(octave[3]);
                        break;
                    case ConsoleKey.A:
                        sound(octave[4]);
                        break;
                    case ConsoleKey.S:
                        sound(octave[5]);
                        break;
                    case ConsoleKey.D:
                        sound(octave[6]);
                        break;
                    case ConsoleKey.F:
                        sound(octave[7]);
                        break;
                    case ConsoleKey.Z:
                        sound(octave[8]);
                        break;
                    case ConsoleKey.X:
                        sound(octave[9]);
                        break;
                    case ConsoleKey.C:
                        sound(octave[10]);
                        break;
                    case ConsoleKey.V:
                        sound(octave[11]);
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    case ConsoleKey.F4:
                        int[] octave4 = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
                        ChangeOctaves(key, octave4);
                        break;
                    case ConsoleKey.F5:
                        int[] octave5 = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
                        ChangeOctaves(key, octave5);
                        break;
                    case ConsoleKey.F6:
                        int[] octave6 = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
                        ChangeOctaves(key, octave6);
                        break;
                    case ConsoleKey.F7:
                        int[] octave7 = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
                        ChangeOctaves(key, octave7);
                        break;
                }
            }
        }
        static int[] ChangeOctaves(ConsoleKeyInfo key, int[] octave)
        {
            if (key.Key == ConsoleKey.F4)
            {
                Octave("4 октава", octave);
            }
            if (key.Key == ConsoleKey.F5)
            {
                Octave("5 октава", octave);
            }
            if (key.Key == ConsoleKey.F6)
            {
                Octave("6 октава", octave);
            }
            if (key.Key == ConsoleKey.F7)
            {
                Octave("7 октава", octave);
            }
            return octave;
        }
    }
}