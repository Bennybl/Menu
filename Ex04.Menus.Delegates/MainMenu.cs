using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private readonly List<string> r_MainMenueItem;
        private readonly string r_MenuTitle;
        private const int k_GoBack = 0;
        private readonly string r_GoBackTitle;
        private readonly MainMenu r_PreviusLevel; 

        public delegate void MenuActionEventHandler(object source, EventArgs menuEventArgs);
        public event MenuActionEventHandler MenuAction;
        public EventArgs userChoiseEvent;

        public MainMenu(List<string> i_MainMenueItem, string i_MenuTitle, MainMenu i_PreviusLevel)
        {
            r_MainMenueItem = i_MainMenueItem;
            r_MenuTitle = i_MenuTitle;
            r_PreviusLevel = i_PreviusLevel;
            if(r_PreviusLevel == null)
            {
                r_GoBackTitle = string.Format("{0} - Exit", k_GoBack);
            }
            else
            {
                r_GoBackTitle = r_GoBackTitle = string.Format("{0} - Go back", k_GoBack);
            }
        }

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine(r_MenuTitle);
            Console.WriteLine();
            Console.WriteLine(r_GoBackTitle);
            int index = 1;
            foreach (string item in r_MainMenueItem)
            {
                string line = string.Format("{0}")
                Console.WriteLine(line);
            }

            int userChoise = int.Parse(Console.ReadLine());
            userChoiseEvent = new UserChoise(userChoise);
            if(userChoise == k_GoBack)
            {
                if(r_PreviusLevel != null)
                {
                    r_PreviusLevel.ShowMenu();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                OnMenuAction(userChoiseEvent);
            }
        }

        public void print(string i_input)
        {
            Console.WriteLine(i_input);
        }

        protected virtual void OnMenuAction(EventArgs i_userChoiseEvent)
        {
            if(MenuAction != null)
            {
                MenuAction(this, i_userChoiseEvent);
            }
        }
    }
}
