﻿using System;
using Course.Services;
namespace Course
{
    delegate void BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            // BinaryNumericOperation op = CalculationService.Sum;
            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;
            // double result = op(a, b);
            op.Invoke(a, b);
        }
    }
}