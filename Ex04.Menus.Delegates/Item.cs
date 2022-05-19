namespace Ex04.Menus.Delegates
{
    public abstract class Item
    {
        private readonly string r_ItemTitle;
        private int m_ItemLevel = 0;

        public Item(string i_Title)
        {
            r_ItemTitle = i_Title;
        }

        public string ItemTitle
        {
            get
            {
                return r_ItemTitle;
            }
        }

        public int ItemLevel
        {
            get
            {
                return m_ItemLevel;
            }
            set
            {
                m_ItemLevel = value;
            }
        }

        internal abstract void Execute();
    }
}