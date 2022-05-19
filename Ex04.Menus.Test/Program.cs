using System;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            InterfaceMenu interfaceMenu = new InterfaceMenu();
            DelegateMenu delegateMenu = new DelegateMenu();

            interfaceMenu.Run();
            Console.Clear();
            Methods.PressAnyKeyToContinue();
            Console.Clear();
            delegateMenu.Run();
        }
    }
}
