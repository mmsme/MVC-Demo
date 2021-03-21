using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Day_4.Models
{
    public class StudentMoc
    {
        private static List<Student> students = new List<Student>()
        {
            new Student(){Id = 1, Name = "Mohamed", Age = 25, Img="/noone.png", Email="examble@gmail.com" },
            new Student(){Id = 2, Name = "Ali", Age = 25, Img="/noone.png", Email="examble@gmail.com"},
            new Student(){Id = 3, Name = "Mahmoud", Age = 25, Img="/noone.png", Email="examble@gmail.com" },
            new Student(){Id = 4, Name = "Aya", Age = 25 , Img="/noone.png", Email="examble@gmail.com"},
            new Student(){Id = 5, Name = "Dina", Age = 25 , Img="/noone.png", Email="examble@gmail.com"},
            new Student(){Id = 6, Name = "Alaa", Age = 25 , Img="/noone.png", Email="examble@gmail.com"},
        };

        public static List<Student> GetStudents()
        {
            return students;
        }

        public static void addNewStudent(Student student)
        {
            if (students.Last() == null)
            {
                student.Id = 1;
            }
            else
            {
                student.Id = students.Last().Id + 1;
            }

            students.Add(student);
        }


        public static void deleteStudent(int id)
        {
            Student s = students.SingleOrDefault(x => x.Id == id);
            students.Remove(s);
        }

        public static Student getStudnetByID(int id)
        {
            Student s = students.SingleOrDefault(x => x.Id == id);
            return s;
        }

        public static void updateStudent(Student student)
        {
            Student s = students.SingleOrDefault(x => x.Id == student.Id);
            s.Name = student.Name;
            s.Age = student.Age;
            s.Img = student.Img;
        }
    }
}