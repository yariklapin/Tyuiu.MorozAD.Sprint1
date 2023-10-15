﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MorozAD.Sprint1.Task1.V7.Lib
{
    public class DataService : ISprint1Task4V7
    {
        public double Calculate(double x, double y)
        {
            var res = (1 + (Math.Sqrt(x * y) /(Math.Pow((x-3*y),2))));
            return res;
        }
    }
}
