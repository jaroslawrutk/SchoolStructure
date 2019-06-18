using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolStructure
{
    class Teacher
    {
        public string first_name { get; set; }
        public string second_name { get; set; }
        public List<Subject> subjects { get; set; }
        public Teacher(string first_name, string second_name, Subject subject)
        {
            this.first_name = first_name;
            this.second_name = second_name;
            this.subjects = new List<Subject>();
            subjects.Add(subject);

        }
        public Teacher(string first_name, string second_name)
        {
            this.first_name = first_name;
            this.second_name = second_name;
            subjects = new List<Subject>();
        }

    }
}
