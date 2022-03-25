using System;
using Interface_Practice.Models;

namespace Interface_Practice.Models
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-------Mekteb Direktorunun Proqrami--------");
            Console.WriteLine("Secin");
            Console.WriteLine("1-Isciler \n2-Sagird \n0-Cixis");
            Console.WriteLine("--------------------------------");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                Start:
                    string name;
                    try
                    {
                        Console.WriteLine("Işçinin adini daxil edin:");
                        name = Console.ReadLine();
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                        goto Start;
                    }
                    string surname;
                    try
                    {
                        Console.WriteLine("Iscinin soyadini daxil edin:");
                        surname = Console.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        goto Start;
                    }
                   
                    int age;
                    try
                    {

                        do
                        {
                            Console.WriteLine("Iscinin yasini daxil edin:");
                            age = Convert.ToInt32(Console.ReadLine());

                        } while (age <= 18 || age >= 65);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        goto Start;
                    }

                    double averageDailyHour;
                    try
                    {
                        do
                        {
                            Console.WriteLine("İşçinin günlük ortalama iş saatini daxil edin:");
                            averageDailyHour = Convert.ToDouble(Console.ReadLine());

                        } while (averageDailyHour > 8);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        goto Start;
                    }
                   
                    double salaryofhour;
                    try
                    {
                        Console.WriteLine("Iscinin saatbaşı qazandığı maaşi daxil edin:");
                        salaryofhour = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        goto Start;
                    }
                    double workinghour;
                    try
                    {
                        do
                        {
                            Console.WriteLine("Iscinin 30 gün ərzində neçə saat işlədiyini daxil edin:");
                            workinghour = Convert.ToDouble(Console.ReadLine());
                        } while (workinghour < 0 || workinghour > 240);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        goto Start;
                    }
                    

                    Employer emplo = new Employer();
                    emplo.CalculateSalary(name, surname, age, salaryofhour, workinghour);
                    break;
                case 2:
                    string name1;
                    try
                    {
                        Console.WriteLine("Sagirdin Adini daxil edin:");
                        name1 = Console.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        goto Start;
                    }
                    string surname1;
                    try
                    {
                        Console.WriteLine("Sagirdin Soyadini Daxil edin:");
                        surname1 = Console.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        goto Start;
                    }
                    
                    int age1;
                    try
                    {
                        do
                        {
                            Console.WriteLine("Sagirdin yasini daxil edin:");
                            age1 = Convert.ToInt32(Console.ReadLine());

                        } while (age1 <= 6 || age1 >= 20);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        goto Start;
                    }

                    double iqRank;
                    try
                    {
                        do
                        {
                            Console.WriteLine("IQ imtahan neticesini daxil edin(100 bal uzerinden):");
                            iqRank = Convert.ToDouble(Console.ReadLine());

                        } while (iqRank > 100);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        goto Start;
                    }

                    double languageRank;
                    try
                    {
                        do
                        {
                            Console.WriteLine("Dil imtahanin neticesini daxil edin(100 bal uzerinden):");
                            languageRank = Convert.ToDouble(Console.ReadLine());

                        } while (languageRank > 100);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        goto Start;
                    }

                    Student student = new Student();
                    student.ExamResult();
                    break;
                default:
                    Console.WriteLine("Sehv Daxil Etdiniz");
                    break;
            }
            while (choice != 0) ;
            

            

            


        }
    }
}
