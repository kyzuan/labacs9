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
       
      
        public static void DoBlock()
        {
            


        }
    }
}

