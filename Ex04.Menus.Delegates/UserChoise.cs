using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class UserChoise : EventArgs
    {
        private int m_Choise;

        public UserChoise (int i_userChoise)
        {
            m_Choise = i_userChoise;
        }
        public int Choise 
        {
            get { return m_Choise ; }
            set { m_Choise = value ; } 
        }
    }
}
