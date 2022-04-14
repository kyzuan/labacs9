using System;
using System.Linq;
namespace labacs9
{
    internal class Block1Var1
    {
        struct MyTime
        {
            public int hour, minute, second;
            public MyTime(int h, int m, int s)
            {
                if(h > 23)
                { h = 23; }
                if(m >= 60)
                { m = 59; }
                if(s >= 60)
                { s = 59; }
                hour = h; minute = m; second = s;
            }
            public override string ToString()
            {
                TimeSpan t = new TimeSpan(hour, minute,second);
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
            if (t.second < 59)
            {
                t.second++;
            }
            else
            {
                t.second = 0;
                if (t.minute < 59)
                {
                    t.minute++;
                }
                else
                {
                    t.minute = 0;
                    if (t.hour < 24)
                    {
                        t.hour++;
                    }
                    else
                    {
                        t.hour = 0;
                    }
                }
            }
            return t;
        }
        static MyTime AddOneMinute(MyTime t)
        {
            if (t.minute < 59)
            {
                t.minute++;
            }
            else
            {
                t.minute = 0;
                if (t.hour < 24)
                {
                    t.hour++;
                }
                else
                {
                    t.hour = 0;
                }
            }
            return t;
        }
        static MyTime AddOneHour(MyTime t)
        {
            if (t.hour < 23)
            {
                t.hour++;
            }
            else
            {
                t.hour = 0;
            }
            return t;
        }
        static int Difference(MyTime mt1, MyTime mt2)
        {
            return TimeSinceMidnight(mt1) - TimeSinceMidnight(mt2);
        }
        static string WhatLesson(MyTime mt)
        {
            int k = TimeSinceMidnight(mt);
            if (k < 28800)
            {
                return "пари ще не почалися";
            }
            if (k >= 28800 && k <= 33600)
            {
                return "1-пара";
            }
            else if (k > 33600 && k < 34800)
            {
                return "перерва між 1-ю та 2 - ю парами,";
            }
            else if (k > 34800 && k < 39600)
            {
                return "2-пара";
            }
            else if (k > 39600 && k < 40800)
            {
                return "перерва між 2-ю та 3 - ю парами,";
            }
            else if (k > 40800 && k < 45600)
            {
                return "3-пара";
            }
            else if (k > 45600 && k < 46800)
            {
                return "перерва між 3-ю та 4 - ю парами,";
            }
            else if (k > 46800 && k < 51600)
            {
                return "4-пара";
            }
            else if (k > 51600 && k < 52800)
            {
                return "перерва між 4-ю та 5-ю парами,";
            }
            else if (k > 52800 && k < 57600)
            {
                return "5-пара";
            }
            else if (k > 57600 && k < 58200)
            {
                return "перерва між 5-ю та 6 - ю парами,";
            }
            else if (k > 58200 && k < 63000)
            {
                return "6-пара";
            }
            return "пари вже скінчилися.";
        }
        public static void DoBlock()
        {
            //
            int c = 0;
            int sec, min, hour;
            int k = 0;
            Console.WriteLine("Введіть значення часу для 1 об`єкту");
            hour = int.Parse(Console.ReadLine());
            min = int.Parse(Console.ReadLine());
            sec = int.Parse(Console.ReadLine());                
            MyTime myTime = new MyTime(hour, min, sec);
            MyTime myTime2;



            while (true)
            {
                Console.WriteLine(myTime.ToString());
                Console.WriteLine("1 - перетворити вказаний час у кількість секунд");
                Console.WriteLine("2 - перетворити кількість секунд, що пройшли від початку доби");
                Console.WriteLine("3 - додати секунду");
                Console.WriteLine("4 - додати хвилину");
                Console.WriteLine("5 - додати годину");
                Console.WriteLine("6 - вернути різницю між двома моментами");
                Console.WriteLine("7 - дізнатися яка зараз пара");
                Console.WriteLine("8 - вивести час");
                Console.WriteLine("9 - переписати значення");
                k = int.Parse(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        Console.WriteLine(TimeSinceMidnight(myTime));
                        break;
                    case 2:
                        Console.WriteLine("Введіть кількість секунд");
                        c = int.Parse(Console.ReadLine());
                        Console.WriteLine(TimeSinceMidnight(k).ToString());
                        break;
                    case 3:
                        myTime = AddOneSecond(myTime);
                        Console.WriteLine(myTime.ToString());
                        break;
                    case 4:
                        myTime = AddOneMinute(myTime);
                        Console.WriteLine(myTime.ToString());
                        break;
                    case 5:
                        myTime = AddOneHour(myTime);
                        Console.WriteLine(myTime.ToString());
                        break;
                    case 6:
                        Console.WriteLine("Введіть значення часу для 2 об`єкту");
                        hour = int.Parse(Console.ReadLine());
                        min = int.Parse(Console.ReadLine());
                        sec = int.Parse(Console.ReadLine());                      
                        myTime2 = new MyTime(hour, min, sec);
                        Console.WriteLine(myTime.ToString());
                        Console.WriteLine(myTime2.ToString());
                        Console.WriteLine("RESULT: ");
                        Console.WriteLine(TimeSinceMidnight(Difference(myTime, myTime2)).ToString());
                        break;
                    case 7:
                        Console.WriteLine(WhatLesson(myTime));
                        break;
                    case 8:
                        Console.WriteLine(myTime.ToString());
                        break;
                    case 9:
                        hour = int.Parse(Console.ReadLine());
                        min = int.Parse(Console.ReadLine());
                        sec = int.Parse(Console.ReadLine());
                        myTime = new MyTime(hour, min, sec);
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
