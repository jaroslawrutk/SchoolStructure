using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolStructure
{
    
    class Classes
    {
        
        public List<Class> classes { get; set; }
        public bool trigger = false;

        public Classes()
        {
            classes = new List<Class>();
        }
        public void AddClass(Class newClass)
        {
            foreach (var i in classes)
            {
                if (i.name == newClass.name) //Sprawdzamy czy istnieje klasa z taką samą nazwą.
                {
                    Console.WriteLine("Student with this number is already exist.");
                    trigger = true;
                    break;
                }
            }
            if (trigger == false)
            {
               
                classes.Add(newClass);

            }
        }
        public void DeleteClass(string name)
        {
            foreach (var i in classes)
            {
                if (i.name == name) //Szukamy klasy o takiej samej nazwie
                {
                    
                    classes.Remove(i);
                    Console.WriteLine("Class with name :" + name + "was deleted");
                    break;
                }
            }
        }
    }
}
