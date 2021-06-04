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
                    DateTime currentTime = DateTime.Now;
                    Console.WriteLine(currentTime.ToString("h:mm:ss tt"));
                    break;

                case 2:
                    DateTime currentDate = DateTime.Today;
                    Console.WriteLine(currentDate.ToString());
                    break;

            }
            con.GoBack();
        }
    }

}
