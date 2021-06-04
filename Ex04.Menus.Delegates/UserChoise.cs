using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class UserChoice : EventArgs
    {
        private int m_Choice;

        public UserChoice (int i_UserChoice)
        {
            m_Choice = i_UserChoice;
        }

        public int Choice 
        {
            get { return m_Choice ; }
            set { m_Choice = value ; } 
        }
    }
}
