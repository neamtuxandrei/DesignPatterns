using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class Element
    {
        protected abstract Button CreateButton();
        public Element() => CreateButton();
    }
    public class NavigationBarF : Element
    {
        protected override Button CreateButton()
        {
            return new Button { Type = "Default Button" };
        }
    }
    public class DropdownMenuF : Element
    {
        protected override Button CreateButton()
        {
            return new Button { Type = "Default Button" };
        }
    }
    public class AndroidNavigationBarF : Element
    {
        protected override Button CreateButton()
        {
            return new Button { Type = "Android Button" };
        }
    }
    public class AndroidDropdownMenuF : Element
    {
        protected override Button CreateButton()
        {
            return new Button { Type = "Android Button" };
        }
    }
}
