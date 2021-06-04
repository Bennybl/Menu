using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
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
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
