using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Practice.Models
{
    class Student:Person
    {
        public double IQRank { get; set; }
        public double LanguageRank { get; set; }

        public Student()
        {
        }

        public Student(string name, string surname, int age,double iqRank,double languageRank)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.IQRank = iqRank;
            this.LanguageRank = languageRank;
        }

        public void ExamResult()
        {
            double Result = IQRank + LanguageRank;
            if (Result>120)
            {
                Console.WriteLine("Imtahani kecdiniz tebrikler ;) ");
            }
            else
            {
                Console.WriteLine("Imtahandan kesildiniz :( ");
            }
        }
    }
}
