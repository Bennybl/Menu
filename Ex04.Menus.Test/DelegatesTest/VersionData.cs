using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class VersionData
    {
        /*
        public void OnMenuAction(object i_PreviusLevel, EventArgs e)
        {
            UserChoice Choice = (UserChoice)e;
            MainMenu con = (MainMenu)i_PreviusLevel;
            switch (Choice.Choice)
            {
                case 1:
                    string firstSubMenuTitle = "Please select option:";
                    List<string> firstSubMenuItem = new List<string>();
                    firstSubMenuItem.Add("Show Version:");
                    firstSubMenuItem.Add("Count Spaces:");
                    MainMenu firstSubMenu = new MainMenu(firstSubMenuItem, firstSubMenuTitle, con);
                    Version version = new Version();
                    firstSubMenu.MenuAction += version.OnMenuAction;
                    firstSubMenu.Show();

                    break;

                case 2:
                    string secondSubMenuTitle = "Please select option:";
                    List<string> secondSubMenuItems = new List<string>();
                    secondSubMenuItems.Add("Show Time");
                    secondSubMenuItems.Add("Show Data");
                    MainMenu secondSubMenu = new MainMenu(secondSubMenuItems, secondSubMenuTitle, con);
                    Time time = new Time();
                    secondSubMenu.MenuAction += time.OnMenuAction;
                    secondSubMenu.Show();
                    break;
            }
        } */
    }
}
