using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interface
{
    public class MainMenu
    {
        private readonly List<string> r_MainMenuStrings;
        private readonly Dictionary<int, MenuItem> r_MenuItems = new Dictionary<int, MenuItem>();
        private readonly string r_MenuTitle;
        private const int k_GoBack = 0;
        private readonly string r_GoBackTitle;
        private readonly List<MenuItem> r_Items;
        private int m_NumOfItems;

        public MainMenu(List<string> i_MainMenuStrings, string i_MenuTitle, MenuItem i_ItemToAddMenu)
        {
            int i = 1;
            r_MainMenuStrings = i_MainMenuStrings;
            r_MenuTitle = i_MenuTitle;
            m_NumOfItems = r_MainMenuStrings.Count;


            foreach (string i_ItemName in r_MainMenuStrings)
            {
                MenuItem item = new MenuItem(i_ItemName);
                r_MenuItems.Add(i, item);
                item.ParentMenu = this;
                i++;
            }

            if (i_ItemToAddMenu == null) ////Main menu
            {
                r_GoBackTitle = string.Format("{0}. Exit", k_GoBack);
            }
            else //// SubMenu
            {
                i_ItemToAddMenu.SubMenu = this;
                r_GoBackTitle = r_GoBackTitle = string.Format("{0}. Go back", k_GoBack);
            
            }
        }

        public void ShowMenu()
        {
            Console.Clear();
            StringBuilder o_Menu = new StringBuilder("");
            o_Menu.AppendLine(r_MenuTitle);
            o_Menu.AppendLine("==============");
            o_Menu.AppendLine();
            int userChoice = -1;
            int i = 1; 

            foreach (string item in r_MainMenuStrings)
            {
                string line = string.Format(@"{0}. {1}", i, item);
                o_Menu.AppendLine(line);
                i++;
            }

            o_Menu.AppendLine(r_GoBackTitle);
            int userChoise = retrieveUserChoice(o_Menu);
            MenuItem o_ItemChosen = null;
            while (userChoise != k_GoBack)
            {
                userChoice = retrieveUserChoice(o_Menu);
                r_MenuItems.TryGetValue(userChoice, out o_ItemChosen);
                ItemChosen(o_ItemChosen);     
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

        public void ItemChosen(MenuItem i_Item)
        {
            if (i_Item.SubMenu != null)
            {
                i_Item.SubMenu.ShowMenu();
            }
            else
            {
     
            }
        }

        public MenuItem GetItem(int index)
        {
                bool itemExist = r_MenuItems.TryGetValue(index, out MenuItem item);
                while (!itemExist)
                {
                    itemExist = r_MenuItems.TryGetValue(index, out item);
                }

            return item;
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
           
        }
    }


