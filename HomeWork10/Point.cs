﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public struct Point
    {
        public int x, y;


        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"({x},{y})";
        }
    }
}
