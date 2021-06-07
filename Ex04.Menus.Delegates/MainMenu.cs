using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private readonly List<string> r_MainMenuItem;
        private readonly string r_MenuTitle;
        private const int k_GoBack = 0;
        private readonly string r_GoBackTitle;
        private readonly MainMenu r_PreviusLevel;

        public delegate void MenuActionEventHandler(object i_Source, EventArgs i_MenuEventArgs);
        public event MenuActionEventHandler MenuAction;
        public EventArgs m_UserChoiceEvent;

        public MainMenu(List<string> i_MainMenuItem, string i_MenuTitle, MainMenu i_PreviusLevel)
        {
            r_MainMenuItem = i_MainMenuItem;
            r_MenuTitle = i_MenuTitle;
            r_PreviusLevel = i_PreviusLevel;
            if (r_PreviusLevel == null)
            {
                r_GoBackTitle = string.Format("{0} - Exit", k_GoBack);
            }
            else
            {
                r_GoBackTitle = r_GoBackTitle = string.Format("{0} - Go back", k_GoBack);
            }
        }

        public void Show()
        {
            Console.Clear();
            Console.WriteLine(r_MenuTitle);
            Console.WriteLine();
            Console.WriteLine(r_GoBackTitle);
            int index = 1;
            foreach (string item in r_MainMenuItem)
            {
                string line = string.Format("{0} - {1}", index, item);
                Console.WriteLine(line);
                index++;
            }

            int userChoice;
            while (true)
            {
                bool isValidInt = int.TryParse(Console.ReadLine(), out userChoice);
                bool isValidRange = inputValidtion(userChoice);
                if (isValidRange && isValidRange)
                {
                    break;
                }

            }

            if (userChoice == k_GoBack)
            {
                if (r_PreviusLevel != null)
                {
                    r_PreviusLevel.Show();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                OnMenuAction(m_UserChoiceEvent);
            }
        }

        public void Print(string i_Input)
        {
            Console.WriteLine(i_Input);
        }

        public void GoBack()
        {

            Console.WriteLine();
            while (true)
            {
                int userChoice;
                Console.WriteLine("Please press 0 to go back...");
                try
                {
                    userChoice = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    userChoice = -1;
                }
                if (userChoice == 0)
                {
                    Show();
                    break;
                }
                Console.WriteLine("Invalid input!");
            }
        }

        private bool inputValidtion(int i_UserChoice)
        {
            bool isValid = i_UserChoice <= r_MainMenuItem.Count && i_UserChoice >= 0;

            return isValid;
        }

        protected virtual void OnMenuAction(EventArgs i_UserChoiceEvent)
        {
            if (MenuAction != null)
            {
                MenuAction(this, i_UserChoiceEvent);
            }
        }
    }

}
