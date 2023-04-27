using System;
using System.Collections.Generic;
using System.Text;

namespace menuComposite
{
    public class Waitress
    {
        MenuComponent allMenus;
        public Waitress(MenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }
        public void printMenu()
        {
            allMenus.print();
        }
    }
}
