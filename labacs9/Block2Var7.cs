using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
namespace labacs9
{
    internal class Block2Var7
    {
        public struct Student
        {
            public string surName;
            public string firstName;
            public string patronymic;
            public char sex;
            public string dateOfBirth;
            public char mathematicsMark;
            public char physicsMark;
            public char informaticsMark;
            public int scholarship;
            public Student(string withAllData)
            {
                string[] arrayWithStudentsData = Regex.Split(withAllData, @"\s+");
                surName = arrayWithStudentsData[0];
                firstName = arrayWithStudentsData[1];
                patronymic = arrayWithStudentsData[2];
                sex = char.Parse(arrayWithStudentsData[3]);
                dateOfBirth = arrayWithStudentsData[4];
                mathematicsMark = char.Parse(arrayWithStudentsData[5]);
                physicsMark = char.Parse(arrayWithStudentsData[6]);
                informaticsMark = char.Parse(arrayWithStudentsData[7]);
                scholarship = int.Parse(arrayWithStudentsData[8]);
            }

        };
        static Student[] ReadData(string path)
        {
            int count = System.IO.File.ReadAllLines(path).Length;
            Student[] arrStudents = new Student[count];
            StreamReader read = new StreamReader(path);
            for (int i = 0; i < arrStudents.Length; i++)
            {
                arrStudents[i] = new Student(read.ReadLine());
            }
            read.Close();
            return arrStudents;
        }
        static void ResultsOfBlock(Student[] arrayOfStudents)
        {
            int sum = 0;
            double avarage = 0;
            for (int i = 0; i < arrayOfStudents.Length; i++)
            {
                sum = int.Parse(arrayOfStudents[i].mathematicsMark.ToString()) + int.Parse(arrayOfStudents[i].physicsMark.ToString()) + int.Parse(arrayOfStudents[i].informaticsMark.ToString());
                avarage = sum / 3;
                if (avarage > 4.5)
                {
                    Console.WriteLine($"{arrayOfStudents[i].surName} {arrayOfStudents[i].firstName} {arrayOfStudents[i].patronymic} {arrayOfStudents[i].physicsMark} ");
                }
            }

        }
        public static void DoBlock()
        {
            Console.WriteLine("Результат виконання.");
            string path = "dataFF.txt";
            ResultsOfBlock(ReadData(path));
            Console.ReadKey();
        }
    }
}
