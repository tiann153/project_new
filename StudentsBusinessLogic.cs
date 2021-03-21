using System;
using System.Collections.Generic;
using System.Text;
using ProjectOne.Common;
using ProjectOne.Data;

namespace ProjectOne.Business
{
    public class StudentsBusinessLogic
    {
        private ProgramData programDbContext;

        //public StudentsBusinessLogic(ProgramData productDbContext)
        //{
        //    this.programDbContext = programDbContext;
        //}

        public List<Students> GetAllStudents()
        {
            return programDbContext.GetAllStudents();
        }

        public Students GetAllStudentsByClass(int classNumber)
        {
            return programDbContext.GetAllStudentsByClass(classNumber);
        }

        public void CreateStudent (Students student)
        {
            this.programDbContext.AddStudent(student);
        }

        public void CreateTeacher(Teachers teacher)
        {
            this.programDbContext.AddTeacher(teacher);
        }

        public void CreateExam(Exams exam)
        {
            this.programDbContext.AddExam(exam);
        }

        public void Delete(int id)
        {
            this.programDbContext.DeleteStudent(id);
        }


    }
}
