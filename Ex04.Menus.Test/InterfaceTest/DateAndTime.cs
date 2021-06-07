using Ex04.Menus.Interface;
using System;
using System.Collections.Generic;
using System.Text;


namespace Ex04.Menus.Test.InterfaceTest
{
    public class DateAndTime : SubMenu, IItemChosen
    {
        public DateAndTime(List<MenuItem> i_ListOfItems, string i_MenuTitle, MenuItem i_ItemToAddMenu)
              : base(i_ListOfItems, i_MenuTitle, i_ItemToAddMenu)
        {

        }

        void IItemChosen.ItemChosen(MenuItem i_Item, int o_Index)
        {
            if (i_Item.SubMenu != null)
            {
                ((i_Item.SubMenu) as SubMenu).ShowMenu();
            }
            else
            {
                switch (o_Index)
                {
                    case 1:
                        showTime();
                        break;
                    case 2:
                        showDate();
                        break;
                }

            }

            void showTime()
            {
                DateTime currentTime = DateTime.Now;
                Console.WriteLine(currentTime.ToString("h:mm:ss tt"));
            }

            void showDate()
            {
                DateTime currentDate = DateTime.Today;
                Console.WriteLine(currentDate.ToString());
            }
        }
    }
}
