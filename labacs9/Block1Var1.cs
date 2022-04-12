using System;

namespace labacs9
{
    internal class Block1Var1
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
        static int TimeSinceMidnight(MyTime t)
        {
            return t.hour * 60 * 60 + t.minute * 60 + t.second;
        }
        static MyTime TimeSinceMidnight(int t)
        {

            int minutes = t / 60;
            int newSec = t - minutes * 60;
            int hour = minutes / 60;
            int newMinnutes = minutes - hour * 60;
            return new MyTime(hour, newMinnutes, newSec);

        }
        static MyTime AddOneSecond(MyTime t)
        {
            return new MyTime();
        }
        public static void DoBlock()
        {
             MyTime myTime = new MyTime(18, 4, 3);
            Console.WriteLine(myTime.ToString());
            Console.WriteLine(TimeSinceMidnight(myTime));
            Console.WriteLine(TimeSinceMidnight(18000));
        }
   
    }
}
