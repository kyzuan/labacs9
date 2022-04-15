using System;

namespace labacs9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("--------------Лаборатоная работа номер 3--------------");
            Console.WriteLine("-------------------Тема: Структуры--------------------");
            onemore:
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("1 - 1 Блок 2 Вариант(Кузьменко Никита)<---------------");
            Console.WriteLine("2 - 2 Блок 15 Вариант(Кузьменко Никита)<--------------");
            Console.WriteLine("3 - 1 Блок 1 Вариант(Шавлак Игорь)<-------------------");
            Console.WriteLine("4 - 2 Блок 7 Вариант(Шавлак Игорь)<-------------------");
            Console.WriteLine("0 - Выход из программы<-------------------------------");
            Console.WriteLine("------------------------------------------------------");
            char cho;
            do
            {
                cho = char.Parse(Console.ReadLine());
                switch (cho)
                {
                    case '1':
                        Block1Var2.DoBlock();
                        Console.Clear();
                        goto onemore;
                        break;
                    case '2':
                        Block2Var15.DoBlock();
                        Console.Clear();
                        goto onemore;
                        break;
                    case '3':
                        Block1Var1.DoBlock();
                        Console.Clear();
                        goto onemore;
                        break;
                    case '4':
                        Block2Var7.DoBlock();
                        Console.Clear();
                        goto onemore;
                        break;
                    default:
                        break;
                }
            } while (cho != '0');
        }
    }
}
