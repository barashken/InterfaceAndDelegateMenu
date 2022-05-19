using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountSpaces : Item, IExecutable
    {
        public CountSpaces(string i_Title) : base(i_Title) { }

        public override void Execute()
        {
            Methods.CountSpaces();
        }
    }
}
