using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class DelegateMenuTest
    {
        public void LunchMainMenu()
        {
            string menuHead = "Main Delegate";

            List<string> items = new List<string>();
            items.Add("1 - Time:");
            items.Add("2 - version:");
            VersionData menege = new VersionData();
            MainMenu menu = new MainMenu(items, menuHead, null);
            menu.MenuAction += menege.OnMenuAction;
            menu.ShowMenu();
        }
    }
}
