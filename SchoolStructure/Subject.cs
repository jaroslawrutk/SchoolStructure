using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolStructure
{
    class Subject
    {
        public string name { get; set; }
        public int nr_of_lessons { get; set; }
        public int nr_of_exercises { get; set; }
        public Subject(string name)
        {
            this.name = name;
        }
    }
}
