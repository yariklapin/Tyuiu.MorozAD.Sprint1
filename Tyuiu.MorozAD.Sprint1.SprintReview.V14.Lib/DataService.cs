﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MorozAD.Sprint1.SprintReview.V14.Lib
{
    public class DataService : ISprint1Task7V2
    {
        public double Calculate(double x, double y)
        {
            double res= (Math.Pow(2,-x)+(5*Math.Pow(x,2)/3*Math.Pow(x,3))-Math.Cos(Math.Pow(x,2))+Math.Sin(2*x*y));
            return res;
        }
    }
}
