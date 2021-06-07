using Ex04.Menus.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test.InterfaceTest
{
    class InterfaceMenuTest
    {
        public void LaunchMainMenu()
        {

            List<MenuItem> items = new List<MenuItem>();
            MenuItem versionAndSpaces = new MenuItem("Version and Spaces");
            MenuItem showDateTime = new MenuItem("Show Data/Time");
            items.Add(versionAndSpaces);
            items.Add(showDateTime);
            MainMenu main = new MainMenu(items, "Main Delegate", null);
            items = new List<MenuItem>();
            MenuItem showVersion = new MenuItem("Show Version");
            MenuItem countSpaces = new MenuItem("Count Spaces");
            items.Add(showVersion);
            items.Add(countSpaces);
            VersionAndSpaces firstSubMenu = new VersionAndSpaces(items, "Version and Spaces:", versionAndSpaces);
            items = new List<MenuItem>();
            MenuItem level2Item3 = new MenuItem("Show Time");
            MenuItem level2Item4 = new MenuItem("Show Date");
            items.Add(level2Item3);
            items.Add(level2Item4);
            DateAndTime secondSubMenu = new DateAndTime(items, "Show Date/Time:", showDateTime);
            main.ShowMenu();
        }
    }
}
