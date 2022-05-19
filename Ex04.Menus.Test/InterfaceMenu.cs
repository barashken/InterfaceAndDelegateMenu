using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfaceMenu 
    {
        private readonly MainMenu r_MainMenu;

        public InterfaceMenu()
        {
            r_MainMenu = new MainMenu("Interface Main Menu");
        }

        public void Run()
        {
            MenuItem dateAndTime = new MenuItem("Show Date/Time");
            MenuItem versionAndSpaces = new MenuItem("Version and Spaces");
            ShowDate showDate = new ShowDate("Show Date");
            ShowTime showTime = new ShowTime("Show Time");
            CountSpaces countSpaces = new CountSpaces("Count Spaces");
            ShowVersion showVersion = new ShowVersion("Show Version");

            r_MainMenu.AddMenuItem(dateAndTime);
            r_MainMenu.AddMenuItem(versionAndSpaces);
            dateAndTime.AddItem(showDate);
            dateAndTime.AddItem(showTime);
            versionAndSpaces.AddItem(countSpaces);
            versionAndSpaces.AddItem(showVersion);
            r_MainMenu.Show();
        }
    }
}
