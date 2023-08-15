﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Button
    {
        public string Type { get; set; }
    }
    public class ButtonFactory
    {
        public static Button CreateButton()
        {
            return new Button { Type = "Red Button" };
        }
    }
    public class NavigationBar
    {
        public NavigationBar() => ButtonFactory.CreateButton();

    }
    public class DropdownMenu
    {
        public DropdownMenu() => ButtonFactory.CreateButton();
    }
}



