using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDate : Item, IExecutable
    {
        public ShowDate(string i_Title) : base(i_Title) { }

        public override void Execute()
        {
            Methods.ShowDate();
        }
    }
}
