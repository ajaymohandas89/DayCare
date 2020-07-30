using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DayCareManagement.Models
{
    public class Student:AbstractPerson
    {
        private double grade { get; }
        private double gpa { get; set; }

        public Student()
        {

        }

        public Student(int Id, string FirstName, string LastName, int Age, double grade,double gpa)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.grade = grade;
            this.gpa = gpa;
        }
    }
}
