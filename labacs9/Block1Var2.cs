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

        public static void DoBlock()
        {
            long n = long.Parse(Console.ReadLine());
            long d = long.Parse(Console.ReadLine());
            MyFrac f = new MyFrac(n, d);
            Console.WriteLine(f.ToString());



        }
    }
}
