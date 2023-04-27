using System;
using System.Collections.Generic;
using System.Text;

namespace menuComposite
{
    public class MenuItem : MenuComponent
    {
        String name;
        String description;
        bool vegetarian;
double price;
public MenuItem(String name,
String description,
bool vegetarian,
double price)
    {
        this.name = name;
        this.description = description;
        this.vegetarian = vegetarian;
        this.price = price;
    }
    public override string getName()
    {
        return name;
    }
    public override string getDescription()
    {
        return description;
    }
    public override decimal getPrice()
    {
        return (decimal)price;
    }
    public override bool isVegetarian()
    {
        return vegetarian;
    }
    public override void print()
    {
        Console.WriteLine(" " + getName());
        if (isVegetarian())
        {
                Console.WriteLine("(v)");
        }
            Console.WriteLine(", " + getPrice());
            Console.WriteLine(" -- " + getDescription());
    }
}
}
