using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.Common
{
    public class Exams
    {
        public Exams()
        {

        }

        public Exams(string subject, int classNumber, int time)
        {

            Subject = subject;
            ClassNumber = classNumber;
            Time = time;
        }

        public string Subject { get; set; }

        public int ClassNumber { get; set; }

        public int Time { get; set; }

        
    }
}

