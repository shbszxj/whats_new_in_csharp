﻿using Infrastructure;
using System;
using static System.Console;

namespace CSharp7
{
    public class LocalFunction : Demo<LocalFunction>
    {
        public override int Title => 5;

        public override void Run()
        {
            var result = EquationSolver.SolveQuadratic(1, 10, 16);
            WriteLine(result);
        }

        class EquationSolver
        {
            private Func<double, double, double, double> OldCalculateDiscriminant = (aa, bb, cc) => bb * bb - 4 * aa * cc;

            public static Tuple<double, double> SolveQuadratic(double a, double b, double c)
            {

                var disc = CalculateDiscriminant();
                var rootDisc = Math.Sqrt(disc);
                return Tuple.Create((-b + rootDisc) / (2 * a), (-b - rootDisc) / (2 * a));

                double CalculateDiscriminant() => b * b - 4 * a * c;
            }
        }
    }
}
