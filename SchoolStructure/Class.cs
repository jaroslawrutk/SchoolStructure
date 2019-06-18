using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SchoolStructure
{
    class Class
    {
        public string name { get; set; }
        public int number_of_techers { get; set; }
        public SortedList students { get; set; }
        public Student help;
        public bool trigger=false;
        
        public Class(string name, int number_of_techers)
        {
            this.name = name;
            this.number_of_techers = number_of_techers;
            students = new SortedList();
        }
        public Class(string name, List<Teacher> teachers, SortedList students)
        {
            this.name = name;
            this.students = students;
        }
        public void AddStudent(Student student)
        {
                students.Add(student.second_name,student);
                
        }
        public void ShowStudent()
        {
            for(int i=0; i< students.Count; i++)
            {
                help=(Student)students.GetByIndex(i);
                Console.WriteLine(help.first_name+' '+ help.second_name);
            }
        }
        
    }
}
