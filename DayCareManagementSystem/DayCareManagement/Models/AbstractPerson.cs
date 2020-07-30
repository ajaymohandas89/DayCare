using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayCareManagement.Models
{
    public class AbstractPerson
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }

        public AbstractPerson()
        {

        }

        public AbstractPerson(int Id, string FirstName, string LastName, int Age)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
        }
    }
}
