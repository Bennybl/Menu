using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interface
{
    public class MainMenu
    {
        private readonly string r_GoBackTitle = string.Format("{0}. Exit", k_GoBack);
        private readonly List<MenuItem> r_MItems;
        private readonly string r_MenuTitle;
        private const int k_GoBack = 0;
        private int m_NumOfItems;

        public MainMenu(List<MenuItem> i_ListOfItems, string i_Title, MenuItem i_ItemToAddMenu)
        {
            r_MenuTitle = i_Title;
            m_NumOfItems = i_ListOfItems.Count;
            r_MItems = new List<MenuItem>(); 

            foreach (MenuItem i_Item in i_ListOfItems)
            {
                r_MItems.Add(i_Item);
                i_Item.ParentMenu = this;
            }
        }

        public string MenuTitle
        {
            get { return r_MenuTitle; }
        }

        public int GoBack
        {
            get { return k_GoBack; }
        }

        public string GoBackTitle
        {
            get { return r_GoBackTitle; }
        }
        public void ShowMenu()
        {
            StringBuilder i_Menu = getMenu();
            int userChoice = retrieveUserChoice(i_Menu);
            MenuItem o_ItemChosen = null;
            while (userChoice != k_GoBack)
            {
                userChoice = retrieveUserChoice(i_Menu);
                o_ItemChosen = r_MItems[userChoice - 1];
                o_ItemChosen.doWhenChosen(userChoice - 1);
            }

            if (o_ItemChosen.ParentMenu != null)
            {
                o_ItemChosen.ParentMenu.ShowMenu();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private int retrieveUserChoice(StringBuilder o_Menu)
        {
            string inputFromUser,msg;
            int o_UserChoice = 0;
            bool isInteger = false;
            bool isValid = false;
            bool isValidRange = false;

            while(!isValid)
            {
                Console.WriteLine(o_Menu);
                msg = string.Format(@"Please enter your choice (1-{0} or 0 to exit):", m_NumOfItems);
                inputFromUser = Console.ReadLine();
                isInteger = int.TryParse(inputFromUser, out o_UserChoice);
                isValidRange = o_UserChoice < 0 || o_UserChoice > m_NumOfItems;
                isValid = isValidRange && isInteger;
                if (isValid)
                {
                    break;
                }
                Console.WriteLine("Invalid input, please try again:");
            }
           
            return o_UserChoice;
            
        }

        private StringBuilder getMenu()
        {
            Console.Clear();
            StringBuilder o_Menu = new StringBuilder("");
            o_Menu.AppendLine(r_MenuTitle);
            o_Menu.AppendLine("==============");
            o_Menu.AppendLine();
            int i = 1;
            foreach (MenuItem item in r_MItems)
            {
                string line = string.Format(@"{0}. {1}", i, item);
                o_Menu.AppendLine(line);
                i++;
            }

            o_Menu.AppendLine(r_GoBackTitle);

            return o_Menu;
        }
           
        }
    }


