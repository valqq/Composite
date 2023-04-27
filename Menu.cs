using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace menuComposite
{
    public class Menu : MenuComponent
    {
        List<MenuComponent> menuComponents = new List<MenuComponent>();
    String name;
    String description;
    public Menu(String name, String description)
    {
        this.name = name;
        this.description = description;
    }
    public override void add(MenuComponent menuComponent)
    {
        menuComponents.Add(menuComponent);
    }
    public override void remove(MenuComponent menuComponent)
    {
        menuComponents.Remove(menuComponent);
    }
    public override MenuComponent getChild(int i)
    {
        return menuComponents.ElementAt(i);
    }
    public override string getName()
    {
        return name;
    }
    public override string getDescription()
    {
        return description;
    }
        
    public override void print()
    {
            Console.Write("\n" + getName());
            Console.WriteLine(", " + getDescription());
            Console.WriteLine("---------------------");

            foreach (MenuComponent menuComponent in menuComponents)
            {
                menuComponent.print();
            }
        }

    }
}
