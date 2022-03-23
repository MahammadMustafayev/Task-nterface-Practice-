using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Practice.Models
{
       abstract class Person
    {
        private int _age;

        public   string Name { get; set; }
        public  string Surname { get; set; }
        public  int Age
        {
            get 
            {
                return _age;
            }
            set 
            {
                if (value>=18 && value<=65)
                {
                    _age = value;
                }
            }
        }

    }
}
