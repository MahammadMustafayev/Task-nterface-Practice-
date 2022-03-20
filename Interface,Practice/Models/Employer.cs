using System;
using System.Collections.Generic;
using System.Text;
using Interface_Practice.Models;

namespace Interface_Practice
{
    class Employer:Person
    {
        
        public double SalaryOfHour { get; set; }
        public double WorkingHour { get; set; }

        //public  double /*Calculate*/Salary { get; set; }

        public Employer()
        {
        }


        public Employer(string name, string surname, int age, double salaryofHour, double workingHour)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.SalaryOfHour = salaryofHour;
            this.WorkingHour = workingHour;
        }

        public void CalculateSalary(string Name,string Surname,int Age,double SalaryOfHour, double WorkingHour)
        {
              
            double salary = WorkingHour * SalaryOfHour;
            if (salary>250)
            {
                Console.WriteLine($"Iscinin ayliq {WorkingHour} saat is vaxtina gore ayliq maasi {salary} manatdir ");
            }
            else
            {
                Console.WriteLine("Iscinin maasi 250 manatdan asaqi ola bilmez");
            }
        }


        

        

    }
}
