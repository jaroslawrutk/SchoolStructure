using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolStructure
{
    class Student
    {
        public string first_name { get; set; }
        public string second_name { get; set; }
        public Student(string first_name, string second_name)
        {
            this.first_name = first_name;
            this.second_name = second_name;
        }
    }
}
