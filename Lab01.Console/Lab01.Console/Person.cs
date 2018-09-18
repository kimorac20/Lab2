using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.Logic
{
    public class Person
    {
        public Person()
        {
        }

        public Person(int id, string name, string lastName)
        {
            Id = id;
            Name = name;
            LastName = lastName;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }


    }
}
