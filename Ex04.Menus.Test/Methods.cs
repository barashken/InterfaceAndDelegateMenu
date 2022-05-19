using System;

namespace Ex04.Menus.Test
{
    public static class Methods
    {
        public static void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            PressAnyKeyToContinue();
        }

        public static void ShowDate()
        {
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
            PressAnyKeyToContinue();
        }

        public static void CountSpaces()
        {
            Console.WriteLine("Please enter a sentence:");
            string sentence = Console.ReadLine();
            int count = countSpaces(sentence);

            Console.WriteLine(string.Format("There are {0} spaces in your sentence", count));
            PressAnyKeyToContinue();
        }

        private static int countSpaces(string i_String)
        {
            int count = 0;

            for (int i = 0; i < i_String.Length; i++)
            {
                if (i_String[i] == ' ')
                {
                    count++;
                }
            }

            return count;
        }

        public static void ShowVersion()
        {
            Console.WriteLine("Version: 22.2.4.8950");
            PressAnyKeyToContinue();
        }

        public static void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
