using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interface
{
    /// <summary>
    /// Root, Node, Leaf
    /// </summary>
    public class MenuItem //: MainMenu
    {
        private readonly string r_Title;
        private MainMenu m_ParentMenu;
        private MainMenu m_SubMenu = null;
        private readonly List<MenuItem> r_MItems;

      /*  public MenuItem(List<MenuItem> i_ListOfItems, string i_MenuTitle, MenuItem i_ItemToAddMenu, string i_Title)
                : base(i_ListOfItems, i_MenuTitle, i_ItemToAddMenu)
        {
            this.r_Title = i_Title;
        }
      */

        public MenuItem(string i_Title)
        {
            r_Title = i_Title;
        }

        public MainMenu SubMenu
        {
            get { return m_SubMenu; }
            set { m_SubMenu = value; }
        }

        public MainMenu ParentMenu
        {
            get { return m_ParentMenu; }
            set { m_ParentMenu = value; }
        }

        public string Title
        {
            get { return r_Title; }
        }

        public void doWhenChosen(int o_Index)
        {
            m_ParentMenu.ItemChosen(this, o_Index);
        }
    }
}
