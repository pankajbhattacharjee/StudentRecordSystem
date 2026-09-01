using System;
using System.Collections.Generic;

namespace StudentRecordSystem
{
    // A simple class representing a Student — demonstrates OOP basics
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public double Marks { get; set; }

        public Student(int id, string name, string course, double marks)
        {
            Id = id;
            Name = name;
            Course = course;
            Marks = marks;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {Id} | Name: {Name} | Course: {Course} | Marks: {Marks}");
        }
    }

    class Program
    {
        // List<Student> acts as our in-memory "database"
        static List<Student> students = new List<Student>();
        static int nextId = 1;

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n===== Student Record Management System =====");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Search Student by ID");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        ViewStudents();
                        break;
                    case "3":
                        UpdateStudent();
                        break;
                    case "4":
                        DeleteStudent();
                        break;
                    case "5":
                        SearchStudent();
                        break;
                    case "6":
                        running = false;
                        Console.WriteLine("Exiting... Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            }
        }

        // CREATE
        static void AddStudent()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Course: ");
            string course = Console.ReadLine();
            Console.Write("Enter Marks: ");
            double marks = Convert.ToDouble(Console.ReadLine());

            Student s = new Student(nextId++, name, course, marks);
            students.Add(s);

            Console.WriteLine("Student added successfully!");
        }

        // READ (all)
        static void ViewStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No records found.");
                return;
            }

            foreach (Student s in students)
            {
                s.Display();
            }
        }

        // UPDATE
        static void UpdateStudent()
        {
            Console.Write("Enter ID of student to update: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Student found = students.Find(s => s.Id == id);

            if (found == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Console.Write("Enter new Name: ");
            found.Name = Console.ReadLine();
            Console.Write("Enter new Course: ");
            found.Course = Console.ReadLine();
            Console.Write("Enter new Marks: ");
            found.Marks = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Student updated successfully!");
        }

        // DELETE
        static void DeleteStudent()
        {
            Console.Write("Enter ID of student to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Student found = students.Find(s => s.Id == id);

            if (found == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            students.Remove(found);
            Console.WriteLine("Student deleted successfully!");
        }

        // READ (single, by ID)
        static void SearchStudent()
        {
            Console.Write("Enter ID to search: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Student found = students.Find(s => s.Id == id);

            if (found == null)
            {
                Console.WriteLine("Student not found.");
            }
            else
            {
                found.Display();
            }
        }
    }
}
