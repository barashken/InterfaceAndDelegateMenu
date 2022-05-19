using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersion : Item, IExecutable
    {
        public ShowVersion(string i_Title) : base(i_Title) { }

        public override void Execute()
        {
            Methods.ShowVersion();
        }
    }
}
