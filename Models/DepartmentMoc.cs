using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Day_4.Models
{
    public class DepartmentMoc
    {
        private static List<Department> Depts = new List<Department>()
        {
            new Department(){ Id = 1, Name="SD", NumOfIns = 5, NumOfStds = 58 },
            new Department(){ Id = 2, Name="OS", NumOfIns = 6, NumOfStds = 25 },
            new Department(){ Id = 3, Name="CS", NumOfIns = 8, NumOfStds = 40 },
            new Department(){ Id = 4, Name="IS", NumOfIns = 6, NumOfStds = 36 },
            new Department(){ Id = 5, Name="IT", NumOfIns = 7, NumOfStds = 100 }
        };

        public static List<Department> GetDepartments()
        {
            return Depts;
        }

        public static void addNewDept(Department dept)
        {
            if (Depts.Last() == null)
            {
                dept.Id = 1;
            }
            else
            {
                dept.Id = Depts.Last().Id + 1;
            }

            Depts.Add(dept);
        }

        public static void deleteDept(int id)
        {
            Department d = Depts.SingleOrDefault(x => x.Id == id);
            Depts.Remove(d);
        }

        public static Department getDeptByID(int id)
        {
            Department d = Depts.SingleOrDefault(x => x.Id == id);
            return d;
        }

        public static void updateDept(Department department)
        {
            Department d = Depts.FirstOrDefault(dept => dept.Id == department.Id);
            d.Name = department.Name;
            d.NumOfIns = department.NumOfIns;
            d.NumOfStds = department.NumOfStds;
        }

    }
}