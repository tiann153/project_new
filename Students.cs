using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.Common
{
    public class Students
    {
        public Students()
        {

        }

        public Students(int id, int number, string name, string surname,int classNumber, double grade)
        {
            Id = id;
            Number = number;
            Name = name;
            Surname = surname;
            ClassNumber = classNumber;
            Grade = grade;
        }

        public int Id { get; set; }

        public int Number { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int ClassNumber { get; set; }

        public double Grade { get; set; }
    }
}
