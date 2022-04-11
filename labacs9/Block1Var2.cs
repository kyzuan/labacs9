﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labacs9
{

    public struct MyFrac
    {
        public long nom, denom;
        
        public MyFrac(long nom_, long denom_)
        {
            nom = nom_;
            denom = denom_;
            long max;
            if (nom > denom)
            {
                max = Math.Abs(nom);
            }
            else
            {
                max = Math.Abs(denom);
            }
            for (long i = max; i >= 2; i--)
            {
                if (nom % i == 0 && denom % i == 0)
                {
                    nom = nom / i;
                    denom = denom / i;
                }
            }
            if (denom < 0)
            {
                nom = -1 * nom;
                denom = Math.Abs(denom);
            }
        }
        public override string ToString()
        {
            return $"{nom}/{denom}";
        }
    }
    internal class Block1Var2
    {
        static double DoubleValue(MyFrac f)
        {
            double result;
            double nom = f.nom;
            double denom = f.denom;
            return nom / denom;
        }
        static MyFrac Plus(MyFrac f1, MyFrac f2)
        {          
            long nok = 0;
            for (int i = 0; i < (f2.denom * f1.denom + 1); i++)
            {
                if (i % f1.denom == 0 && i % f2.denom == 0)
                {
                    nok = i;
                    if (i != 0)
                    {  
                        break;
                    }
                }
            }
            f1.nom = f1.nom * (nok / f1.denom);
            f2.nom = f2.nom * (nok / f2.denom);
            MyFrac res = new MyFrac(f1.nom+f2.nom, nok);
            return res;
        }
        static MyFrac Minus(MyFrac f1, MyFrac f2)
        { 
            long nok = 0;
            for (int i = 0; i < (f2.denom * f1.denom + 1); i++)
            {
                if (i % f1.denom == 0 && i % f2.denom == 0)
                {
                    nok = i;
                    if (i != 0)
                    {
                        break;
                    }
                }
            }
            f1.nom = f1.nom * (nok / f1.denom);
            f2.nom = f2.nom * (nok / f2.denom);
            MyFrac res = new MyFrac(f1.nom - f2.nom, nok);
            return res;
        }
        static MyFrac Multiply(MyFrac f1, MyFrac f2)
        {
            MyFrac res = new MyFrac(f1.nom * f2.nom, f1.denom * f2.denom);
            return res;
        }
        static MyFrac Divide(MyFrac f1, MyFrac f2)
        {
            MyFrac res = new MyFrac(f1.nom * f2.denom, f1.denom * f2.nom);
            return res;
        }
        public static void DoBlock()
        {
            Console.WriteLine("Введите значение числителя дроби:");
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение знаменателя дроби:");
            long d = long.Parse(Console.ReadLine());
            MyFrac f = new MyFrac(n, d);
            Console.WriteLine($"Полученная дробь: {f.ToString()} ");  
            Console.WriteLine($"Истинное значение дроби: {DoubleValue(f)}");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Введите значение числителя первой дроби:");
            long n1 = long.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение знаменателя первой дроби:");
            long d1 = long.Parse(Console.ReadLine());
            MyFrac f1 = new MyFrac(n1, d1);
            Console.WriteLine($"Полученная дробь: {f1.ToString()} ");           
            Console.WriteLine("Введите значение числителя второй дроби:");
            long n2 = long.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение знаменателя второй дроби:");
            long d2 = long.Parse(Console.ReadLine());
            MyFrac f2 = new MyFrac(n2, d2);
            Console.WriteLine($"Полученная дробь: {f2.ToString()}");
            MyFrac res = Plus(f1, f2);
            Console.WriteLine($"Результат сложения двух дробей: {res.ToString()} ");
            res = Minus(f1, f2);
            Console.WriteLine($"Результат вычитания двух дробей: {res.ToString()} ");
            res = Multiply(f1, f2);
            Console.WriteLine($"Результат умножения двух дробей: {res.ToString()} ");
            res = Divide(f1, f2);
            Console.WriteLine($"Результат деления двух дробей: {res.ToString()} ");
        }
    }
}
