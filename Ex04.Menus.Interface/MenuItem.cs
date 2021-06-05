using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interface
{
    public class MenuItem
    {
        private readonly string r_Name;
        private MainMenu m_ParentMenu;
        private MainMenu m_SubMenu = null;
        public MenuItem(string i_Name)
        {
            this.r_Name = i_Name;
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

        private void doWhenChosen()
        {
            m_ParentMenu.ItemChosen(this);
        }
    }
}
