using System;
using Interface_Practice.Models;

namespace Interface_Practice.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Employer
            //Console.WriteLine("Işçinin adini daxil edin:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Iscinin soyadini daxil edin:");
            //string surname = Console.ReadLine();

            //int age;

            //do
            //{
            //    Console.WriteLine("Iscinin yasini daxil edin:");
            //     age = Convert.ToInt32(Console.ReadLine());

            //} while (age<=18 || age>=65);

            //double averageDailyHour;
            //do
            //{
            //    Console.WriteLine("İşçinin günlük ortalama iş saatini daxil edin:");
            //    averageDailyHour = Convert.ToDouble(Console.ReadLine());

            //} while (averageDailyHour>8);

            //Console.WriteLine("Iscinin saatbaşı qazandığı maaşi daxil edin:");
            //double salaryofhour = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Iscinin 30 gün ərzində neçə saat işlədiyini daxil edin:");
            //double workinghour = Convert.ToDouble(Console.ReadLine());

            //Employer emplo = new Employer();     
            //emplo.CalculateSalary(name, surname, age, salaryofhour, workinghour);

            #endregion
            #region Student

            Console.WriteLine("Sagirdin Adini daxil edin:");
            string name = Console.ReadLine();
            Console.WriteLine("Sagirdin Soyadini Daxil edin:");
            string surname = Console.ReadLine();

            int age;
            do
            {
                Console.WriteLine("Sagirdin yasini daxil edin:");
                age = Convert.ToInt32(Console.ReadLine());

            } while (age<=6 || age>=20);
 
            double iqRank;

            do
            {
                Console.WriteLine("IQ imtahan neticesini daxil edin(100 bal uzerinden):");
                iqRank = Convert.ToDouble(Console.ReadLine());

            } while (iqRank>100);

            double languageRank;
            do
            {
                Console.WriteLine("Dil imtahanin neticesini daxil edin(100 bal uzerinden):");
                languageRank = Convert.ToDouble(Console.ReadLine());

            } while (languageRank>100);

            Student student = new Student();
            student.ExamResult();

            #endregion

            


        }
    }
}
