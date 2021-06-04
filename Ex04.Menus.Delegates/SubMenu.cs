using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class SubMenu
    {
        private readonly List<string> m_MainMenueItem;

        public SubMenu (List<string> i_MainMenueItem)
        {
            m_MainMenueItem = i_MainMenueItem;
        }
    }
}
