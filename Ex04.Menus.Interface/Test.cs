using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interface
{
    public class Test                       ////Test: MainMenu, IItemChosen
    {
        public Test()//(List<MenuItem> i_ListOfItems, string i_MenuTitle, MenuItem i_ItemToAddMenu)
               // : base(i_ListOfItems, i_MenuTitle, i_ItemToAddMenu)
        {
        }
        public void init()
        {
           
            List<MenuItem> items = new List<MenuItem>();
            MenuItem level1Item1 = new MenuItem("Version and Spaces");
            MenuItem level1Item2 = new MenuItem("Show Data/Time");
            items.Add(level1Item1);
            items.Add(level1Item2);
            SubMenu smenu = new SubMenu(items, "", level1Item1);
          
            MainMenu main = new MainMenu(items, "Main Delegate", null);
            items = new List<MenuItem>();
            MenuItem level2Item1 = new MenuItem("Show Version");
            MenuItem level2Item2 = new MenuItem("Count Spaces");
            items.Add(level2Item1);
            items.Add(level2Item2);
            MainMenu firstSubMenu = new MainMenu(items, "Please select option:", level1Item1);
            items = new List<MenuItem>();
            MenuItem level2Item3 = new MenuItem("Show Time");
            MenuItem level2Item4 = new MenuItem("Show Date");
            items.Add(level2Item3);
            items.Add(level2Item4);
            MainMenu secondSubMenu = new MainMenu(items, "Please select option:", level1Item2);
        }

        void ItemChosen(MenuItem i_Item)
        {
            if (i_Item.SubMenu != null)
            {
                i_Item.SubMenu.ShowMenu();
            }
            else
            {

            }
        }
    }
}
