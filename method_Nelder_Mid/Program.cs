using System;
using System.Collections.Generic;
using System.Text;

namespace method_Nelder_Mid
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Dimension = 2;
            double[] Vector = new double[Dimension + 1];
            NelderMid Jedi = new NelderMid();
            double[] X = { -2, 2 };
            double L, L_thres, cR, alpha, beta, gamma;
            L = 0.4;
            L_thres = 1.0e-5;
            cR = 1.0;
            alpha = 2.0;
            beta = 0.5;
            gamma = 0.5;
            Console.WriteLine("Начальная точка:");
            for (int i = 0; i < Dimension; i++) Console.WriteLine(X[i]);
            Vector = Jedi.nelMead(ref X, Dimension, L, L_thres, cR, alpha, beta, gamma);
            Console.WriteLine("Результат:");
            Console.WriteLine("Аргументы:");
            for (int i = 0; i < Dimension; i++) Console.WriteLine(X[i]);
            Console.WriteLine("Функция в вершинах симплекса:");
            for (int i = 0; i < Dimension + 1; i++) Console.WriteLine(Vector[i]);

            Console.ReadKey();
        }
    }
}
