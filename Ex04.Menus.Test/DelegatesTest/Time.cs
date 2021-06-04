using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
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
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }

}
