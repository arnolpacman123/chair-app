﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace ChairApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            GameWindow window = new GameWindow(800, 600);
            Window newWindow = new Window(window);
        }
    }
}
