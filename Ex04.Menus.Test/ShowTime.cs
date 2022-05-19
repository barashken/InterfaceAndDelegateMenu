using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTime : Item, IExecutable
    {
        public ShowTime(string i_Title) : base(i_Title) { }

        public override void Execute()
        {
            Methods.ShowTime();
        }
    }
}
