namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private readonly MenuItem r_MainMenuItem;

        public MainMenu(string i_Title)
        {
            r_MainMenuItem = new MenuItem(i_Title);
            r_MainMenuItem.ItemLevel = 0;
        }

        public MenuItem MainMenuItem
        {
            get
            {
                return r_MainMenuItem;
            }
        }

        public void AddMenuItem(Item i_Item)
        {
            MainMenuItem.AddItem(i_Item);
        }

        public void Show()
        {
            MainMenuItem.Execute();
        }
    }
}
