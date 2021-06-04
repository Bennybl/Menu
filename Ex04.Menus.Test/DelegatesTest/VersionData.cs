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
                    string menuHead = "Please select option:";
                    List<string> items = new List<string>();
                    items.Add("1 - Show Version:");
                    items.Add("2 - Count Spaces:");
                    MainMenu menu = new MainMenu(items, menuHead, con);
                    Time time = new Time();
                    menu.MenuAction += time.OnMenuAction;
                    menu.ShowMenu();
                    break;

                case 2:
                    string menuHead1 = "Please select option:";

                    List<string> items1 = new List<string>();
                    items1.Add("1 - Show Time");
                    items1.Add("2 - Show Data");
                    MainMenu menu1 = new MainMenu(items1, menuHead1, con);
                    Version version = new Version();
                    menu1.MenuAction += version.OnMenuAction;
                    menu1.ShowMenu();
                    break;
            }
        }
    }
}
