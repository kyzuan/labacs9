using System;

namespace lab3
{
    internal class Program
    {
        struct MyTime
        {
            public int hour, minute, second;
            public MyTime(int h, int m, int s)
            {
                hour = h; minute = m; second = s;
            }
            public override string ToString()
            {
                
                TimeSpan t = new TimeSpan(hour, minute, second);
                return t.ToString((@"hh\:mm\:ss"));

            }
        };
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            MyTime myTime = new MyTime(18, 4, 3);
            string a = myTime.ToString();
            Console.WriteLine(a);

        }
    }
}
