﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class FindValues
    {
        public double findArea(double radius)
        {
            double pi = 3.14159265;
            return pi * radius * radius; 
        }

        public double findCicumference(double radius)
        {
            double pi = 3.14159265;
            return 2 * pi * radius;
        }
    }
}
