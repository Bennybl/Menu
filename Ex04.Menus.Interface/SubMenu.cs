﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interface
{
    public class SubMenu: MainMenu
    {
        public SubMenu(List<MenuItem> i_ListOfItems, string i_MenuTitle, MenuItem i_ItemToAddMenu)
                : base(i_ListOfItems, i_MenuTitle, i_ItemToAddMenu)
        {
            i_ItemToAddMenu.SubMenu = this;
        }

    }
}
