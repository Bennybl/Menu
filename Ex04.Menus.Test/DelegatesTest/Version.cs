using System;
using System.Reflection;
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
                    string currentVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                    con.print(currentVersion);
                    break;

                case 2:
                    con.print(CountSpaces());
                    break;
            }
            con.GoBack();
        }

        private string CountSpaces()
        {
            Console.WriteLine("Please type as you will");
            string userInput = Console.ReadLine();
            int numOfSpaces = userInput.Split(' ').Length - 1;
            return string.Format("Number of spaces: {0}", numOfSpaces);
        }
    }
}
