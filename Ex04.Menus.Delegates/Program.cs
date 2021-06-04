using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    class Program
    {
        //public static MainMenu.MenuActionEventHandler OnMenuAction { get; private set; }

        static void Main(string[] args)
        {
            string menuHead = "Menu!!";

            List<string> items = new List<string>();
            items.Add("1. Time:");
            items.Add("2. Show SubMenu:");
            MenegeMenu menege = new MenegeMenu();
            MainMenu menu = new MainMenu(items, menuHead , null);
            menu.MenuAction += menege.OnMenuAction;
            menu.ShowMenu();

        }


        public class MenegeMenu
        {
            public void OnMenuAction(object souce, EventArgs e)
            {
                UserChoise choise = (UserChoise)e;
                MainMenu con = (MainMenu)souce;
                switch (choise.Choise)
                {
                    case 1:
                        string menuHead = "time!!";

                        List<string> items = new List<string>();
                        items.Add("1. Time in Us:");
                        items.Add("2. Time in Isreal:");

                        MainMenu menu = new MainMenu(items, menuHead, con);
                        Time time = new Time();
                        menu.MenuAction += time.OnMenuAction;
                        menu.ShowMenu();
                        break;

                    case 2:
                        string menuHead1 = "SubMenu!!";

                        List<string> items1 = new List<string>();
                        items1.Add("1. Sub in Us:");
                        items1.Add("2. Sub in Isreal:");

                        MainMenu menu1 = new MainMenu(items1, menuHead1 , con);
                        Version version = new Version();
                        menu1.MenuAction += version.OnMenuAction;
                        menu1.ShowMenu();
                        break;
          

                }
            }
        }

        public class Time
        {
            public void OnMenuAction(object souce, EventArgs e)
            {
                UserChoise choise = (UserChoise)e;
                MainMenu con = (MainMenu)souce;
                switch (choise.Choise)
                {
                    case 1:
                        
                        con.print("time in us is: 4:30");
                        break;

                    case 2:
                        con.print("time in IL is: 12:30");
                        break;

                }
            }
        }


        public class Version
        {
            public void OnMenuAction(object souce, EventArgs e)
            {
                UserChoise choise = (UserChoise)e;
                MainMenu con = (MainMenu)souce;
                switch (choise.Choise)
                {
                    case 1:

                        con.print("Version is: 5.54.30");
                        break;

                    case 2:
                        con.print("No new version");
                        break;

                }
            }
        }
    }
 }
