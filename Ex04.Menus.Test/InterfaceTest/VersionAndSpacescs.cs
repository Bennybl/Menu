using Ex04.Menus.Interface;
using System;
using System.Collections.Generic;
using System.Text;


namespace Ex04.Menus.Test.InterfaceTest
{
    public class VersionAndSpaces : SubMenu, IItemChosen
    {
        public VersionAndSpaces(List<MenuItem> i_ListOfItems, string i_MenuTitle, MenuItem i_ItemToAddMenu)
              : base(i_ListOfItems, i_MenuTitle, i_ItemToAddMenu)
        {
            i_ItemToAddMenu.SubMenu = this;
        }

        void IItemChosen.ItemChosen(MenuItem i_Item, int o_Index) 
        {
                switch (o_Index)
                {
                    case 1:
                        showVersion();
                        break;
                    case 2:
                        countSpaces();
                        break;
                }
                
            }

             void showVersion()
            {
                Console.WriteLine("App Version: 21.1.4.8930");
            }

            void countSpaces()
            {
                Console.WriteLine("Please type as you will");
                string userInput = Console.ReadLine();
                int numOfSpaces = userInput.Split(' ').Length - 1;
                string output = string.Format("Number of spaces: {0}", numOfSpaces);
                Console.WriteLine(output);
            }
        }
    }

