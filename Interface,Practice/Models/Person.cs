using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Practice.Models
{
       class Person
    {
        private int _age;

        public  /*static*/ string Name { get; set; }
        public  /*static*/ string Surname { get; set; }
        public /*static*/ int Age
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
