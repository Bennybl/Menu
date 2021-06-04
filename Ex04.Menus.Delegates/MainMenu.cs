using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    class MainMenu
    {
        private readonly List<string> m_MainMenueItem;
        private readonly string m_MenuTitle;
        private const int k_GoBack = 0;
        private readonly string m_GoBackTitle;
        private readonly MainMenu r_PreviusLevel; 

        public delegate void MenuActionEventHandler(object source, EventArgs menuEventArgs);
        public event MenuActionEventHandler MenuAction;
        public EventArgs userChoiseEvent;

        public MainMenu(List<string> i_MainMenueItem, string i_MenuTitle, MainMenu i_PreviusLevel)
        {
            m_MainMenueItem = i_MainMenueItem;
            m_MenuTitle = i_MenuTitle;
            r_PreviusLevel = i_PreviusLevel;
            if(r_PreviusLevel == null)
            {
                m_GoBackTitle = string.Format("{0} - Exit", k_GoBack);
            }
            else
            {
                m_GoBackTitle = m_GoBackTitle = string.Format("{0} - Go back", k_GoBack);
            }
        }

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine(m_MenuTitle);
            Console.WriteLine();
            Console.WriteLine(m_GoBackTitle);
            foreach (string line in m_MainMenueItem)
            {
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
