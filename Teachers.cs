using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.Common
{
    public class Teachers
    {
        public Teachers()
        {

        }

        public Teachers(int id, string name, string surname, int classNumber, string exam)
        {
            Id = id;
            Name = name;
            Surname = surname;
            ClassNumber = classNumber;
            Exam = exam;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int ClassNumber { get; set; }

        public string Exam { get; set; }
    }
}

