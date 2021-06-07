using Ex04.Menus.Test.InterfaceTest;
using System;

namespace Ex04.Menus.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateMenuTest delegateMenu = new DelegateMenuTest();
            delegateMenu.LunchMainMenu();

            InterfaceMenuTest interfaceMenu = new InterfaceMenuTest();
            interfaceMenu.LaunchMainMenu();
        }
    }
}
