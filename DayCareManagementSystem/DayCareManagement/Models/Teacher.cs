using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayCareManagement.Models
{
    public class Teacher:AbstractPerson
    {
        private int credit { get; set; }

        public Teacher()
        {

        }

        public Teacher(int Id, string FirstName, string LastName, int Age,int credit)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.credit = credit;
        }
    }
}
