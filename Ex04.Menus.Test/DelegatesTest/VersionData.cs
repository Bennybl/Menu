using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class VersionData
    {
        public void OnMenuAction(object i_PreviusLevel, EventArgs e)
        {
            UserChoise choise = (UserChoise)e;
            MainMenu con = (MainMenu)i_PreviusLevel;
            switch (choise.Choise)
            {
                case 1:
                    string firstSubMenuTitle = "Please select option:";
                    List<string> firstSubMenuItem = new List<string>();
                    firstSubMenuItem.Add("Show Version:");
                    firstSubMenuItem.Add("Count Spaces:");
                    MainMenu firstSubMenu = new MainMenu(firstSubMenuItem, firstSubMenuTitle, con);
                    Version version = new Version();
                    firstSubMenu.MenuAction += version.OnMenuAction;
                    firstSubMenu.ShowMenu();

                    break;

                case 2:
                    string secondSubMenuTitle = "Please select option:";
                    List<string> secondSubMenuItems = new List<string>();
                    secondSubMenuItems.Add("Show Time");
                    secondSubMenuItems.Add("Show Data");
                    MainMenu mesecondSubMenu = new MainMenu(secondSubMenuItems, secondSubMenuTitle, con);
                    Time time = new Time();
                    mesecondSubMenu.MenuAction += time.OnMenuAction;
                    mesecondSubMenu.ShowMenu();
                    break;
            }
        }
    }
}
