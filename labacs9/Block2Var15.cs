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
        
    }
    internal class Block2Var15
    {
       static Student[] ReadData(string path)
        {
            int count = System.IO.File.ReadAllLines(path).Length;
            Student[] arrayFromStudents = new Student[count];
            StreamReader read = new StreamReader(path);
            for (int i = 0; i < arrayFromStudents.Length; i++)
            {
                arrayFromStudents[i] = new Student(read.ReadLine());
            }
            read.Close();
            return arrayFromStudents;
        }
        static void ResultsOfBlock(Student[] arrayOfStudents)
        {
            for (int i = 0; i < arrayOfStudents.Length; i++)
            {
                if (arrayOfStudents[i].mathematicsMark >= 3 && arrayOfStudents[i].physicsMark >= 3 && arrayOfStudents[i].informaticsMark >= 3)
                {
                    Console.WriteLine($"{arrayOfStudents[i].surName} {arrayOfStudents[i].firstName} {arrayOfStudents[i].patronymic}. Стипендия: {arrayOfStudents[i].scholarship} грн.");
                }
            }
            
        }
       
        public static void DoBlock()
        {
            Console.WriteLine("Результат исполнения блока.");
            string path = "dataKuz.txt";
            ResultsOfBlock(ReadData(path));
            Console.ReadKey();
        }
    }
}

