using System;
using System.Collections.Generic;


namespace SchoolStructure
{
    class School
    {
        public static void showMenu()
        {
            Console.WriteLine("WELCOME TO OUR SCHOOL SYSTEM, WHAT YOU WHAT TO DO");
            Console.WriteLine();
            Console.WriteLine("**************************************************");
            Console.WriteLine();
            Console.WriteLine("1. Manage Classes");
            Console.WriteLine();
            Console.WriteLine("2. Manage Students");
            Console.WriteLine();
            Console.WriteLine("3. Teachers");
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            Classes classes = new Classes();
            Class newClass;
            Subject subject;
            Student student = new Student("SampleName","SampleSecondName");

            newClass = new Class("super",5);
            newClass.AddStudent(student);
            classes.AddClass(newClass);
            

            List<Teacher> teachers = new List<Teacher>();


            string option, option2, option3, option4, option5;
      

            showMenu();

            for (; ; )
            {
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("1. Show All classes");
                        Console.WriteLine();
                        Console.WriteLine("2. Add Class");
                        Console.WriteLine();
                        Console.WriteLine("3. Delete Class");
                        Console.WriteLine();
                        Console.WriteLine("4. Back");
                        Console.WriteLine();
                        option2 = Console.ReadLine();
                        switch (option2)
                        {
                            case "1":
                                foreach (var i in classes.classes)
                                {
                                    Console.WriteLine("Name: " + i.name);
                                    Console.WriteLine("Number of Teachers: " + i.number_of_techers);
                                    Console.WriteLine("Students: ");
                                    i.ShowStudent();
                                }
                                break;
                            case "2":
                                Console.WriteLine("Write name of class");
                                option3 = Console.ReadLine();
                                Console.WriteLine("How Much Teachers?");
                                option4 = Console.ReadLine();
                                classes.AddClass(new Class(option3, Convert.ToInt32(option4)));
                                break;
                            case "3":
                                Console.WriteLine("Write name of class to delete");
                                option3 = Console.ReadLine();
                                classes.DeleteClass(option3);
                                break;
                            case "4":
                                break;
                            default:
                                Console.WriteLine("WRONG NUMBER");
                                continue;

                        }
                        showMenu();
                        break;
                    case "2":
                        Console.WriteLine("1. Show All students");
                        Console.WriteLine();
                        Console.WriteLine("2. Add Student");
                        Console.WriteLine();
                        Console.WriteLine("3. Back");
                        Console.WriteLine();
                        option2 = Console.ReadLine();
                        switch (option2)
                        {
                            case "1":
                                foreach (var i in classes.classes)
                                {
                                    i.ShowStudent();
                                }
                                break;
                            case "2":
                                Console.WriteLine("Write first name of Student");
                                option3 = Console.ReadLine();
                                Console.WriteLine("Write second name of Student");
                                option4 = Console.ReadLine();
                                Console.WriteLine("Name of class");
                                option5 = Console.ReadLine();
                                foreach (var i in classes.classes)
                                {
                                    if (i.name == option5)
                                    {
                                        i.AddStudent(new Student(option3, option4));
                                    }
                                }
                                break;
                            case "3":
                                break;
                            default:
                                Console.WriteLine("WRONG NUMBER");
                                continue;
                        }
                        showMenu();
                        break;

                    case "3":
                        Console.WriteLine("1. Show All Teachers");
                        Console.WriteLine();
                        Console.WriteLine("2. Add Teachers");
                        Console.WriteLine();
                        Console.WriteLine("3. Delete Teachers");
                        Console.WriteLine();
                        Console.WriteLine("3. Exit");
                        Console.WriteLine();
                        option2 = Console.ReadLine();
                        switch (option2)
                        {
                            case "1":
                                if (teachers.Count == 0)
                                    Console.WriteLine("There is no teachers");
                                else
                                {
                                    foreach (var i in teachers)
                                    {
                                        Console.WriteLine(i.first_name + " " + i.second_name);
                                    }
                                }
                                break;
                            case "2":
                                Console.WriteLine("Write first name of Teacher");
                                option3 = Console.ReadLine();
                                Console.WriteLine("Write second name of Teacher");
                                option5 = Console.ReadLine();
                                Console.WriteLine("Name of his subject");
                                option4 = Console.ReadLine();
                                teachers.Add(new Teacher(option3, option4, new Subject(option5)));
                                break;
                            case "3":
                                Console.WriteLine("Write first name of Teacher to delete");
                                option3 = Console.ReadLine();
                                Console.WriteLine("Write second name of Teacher to delete");
                                option5 = Console.ReadLine();

                                foreach (var i in teachers)
                                {
                                    if (i.first_name == option3 && i.second_name == option5) //Szukamy klasy o takiej samej nazwie
                                    {
                                        teachers.Remove(i);
                                        Console.WriteLine("Teacher with name :" + i.first_name+" " + i.second_name+ "was deleted");
                                        break;
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("WRONG NUMBER");
                                continue;
                        }
                        showMenu();
                        break;
                }


            }

        }
    }
}
