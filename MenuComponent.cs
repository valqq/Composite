using System;
using System.Collections.Generic;
using System.Text;

namespace menuComposite
{
    public abstract class MenuComponent
    {
        public virtual void add(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }
        public virtual void remove(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }
        public virtual MenuComponent getChild(int i)
        {
            throw new NotImplementedException();
        }
        public virtual string getName()
        {
            throw new NotImplementedException();
        }
        public virtual string getDescription()
        {
            throw new NotImplementedException();
        }
        public virtual decimal getPrice()
        {
            throw new NotImplementedException();
        }
        public virtual bool isVegetarian()
        {
            throw new NotImplementedException();
        }
        public virtual void print()
        {
            throw new NotImplementedException();
        }

      
    }
}
