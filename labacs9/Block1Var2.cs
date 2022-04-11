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
            int nod = GetNod(nom, denom);
            nom = nom / nod;
            denom = denom / nod;
            
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
            long n = long.Parse(Console.ReadLine());
            long d = long.Parse(Console.ReadLine());    
            MyFrac f = new MyFrac(n,d);
            Console.WriteLine(f.ToString());
        }
        public static void DoBlock()
        {
            ResultOfStructWork();

        }
    }
}
