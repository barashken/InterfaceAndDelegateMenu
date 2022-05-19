using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class DelegateMenu
    {
        private readonly MainMenu r_MainMenu;

        public DelegateMenu()
        {
            r_MainMenu = new MainMenu("Delegate Main Menu");
        }

        public void Run()
        {
            MenuItem dateAndTime = new MenuItem("Show Date/Time");
            MenuItem versionAndSpaces = new MenuItem("Version and Spaces");
            ActionItem showDate = new ActionItem("Show Date");
            ActionItem showTime = new ActionItem("Show Time");
            ActionItem countSpaces = new ActionItem("Count Spaces");
            ActionItem showVersion = new ActionItem("Show Version");

            showDate.Action += Methods.ShowDate;
            showTime.Action += Methods.ShowTime;
            countSpaces.Action += Methods.CountSpaces;
            showVersion.Action += Methods.ShowVersion;
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
