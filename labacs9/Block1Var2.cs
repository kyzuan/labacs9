using System;
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
            if (denom < 0)
            {
                denom = Math.Abs(denom);
                nom = -nom; 
            }
        
        }
        public MyFrac CutFrac(MyFrac f)
        {  
            int nod = GetNod(f.nom, f.denom);
            f.nom = f.nom / nod;
            f.denom = f.denom / nod;
            return f;
        }
        public static int GetNod(long n, long d) 
        {
            int nod = 0;
            if (n < 0)
            {
                n = Math.Abs(n);
            }
            while (n != d)
            {
                if (n > d)
                {
                    n = n - d;
                }
                else
                {
                    d = d - n;
                }
            }
            nod = (int)d;
            return nod;
        
        }
        public override string ToString()
        {
            return nom + "/" + denom;
        }
    }
    internal class Block1Var2
    {
        public static void ResultOfStructWork()
        {
            Console.WriteLine("Проверка работы структуры на сокращение дроби.");
            Console.WriteLine("Введите значение числителя: ");
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение знаменателя: ");
            long d = long.Parse(Console.ReadLine());    
            MyFrac f = new MyFrac(n,d);
            Console.WriteLine("Резульат сокращения дроби: ");
            Console.WriteLine(f.CutFrac(f).ToString());          
        }
        static double DoubleValue(MyFrac f)
        {
            double dnom = double.Parse(f.nom.ToString());
            double ddenom = double.Parse(f.denom.ToString());
            double res = dnom / ddenom;
            return res; 
        }

        public static void DoBlock()
        {          
            ResultOfStructWork();
            Console.WriteLine("Исполнение основных методов блока.");
            Console.WriteLine("Введите значение числителя: ");
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение знаменателя: ");
            long d = long.Parse(Console.ReadLine());
            MyFrac f = new MyFrac(n, d);
            Console.WriteLine("Полученная дробь:");
            Console.WriteLine(f.ToString());
            //Место для пропущеного метода
            Console.WriteLine("Истинное значение дроби: ");
            Console.WriteLine(DoubleValue(f));
            

        }
    }
}
