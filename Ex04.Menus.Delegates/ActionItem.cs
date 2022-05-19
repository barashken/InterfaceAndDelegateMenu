using System;

namespace Ex04.Menus.Delegates
{
    public class ActionItem : Item
    {
        public event Action Action;

        public ActionItem(string i_Title) : base(i_Title) { }

        internal override void Execute()
        {
            OnAction();
        }

        private void OnAction()
        {
            if (Action != null)
            {
                Action.Invoke();
            }
        }
    }
}