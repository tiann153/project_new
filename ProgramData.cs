using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using ProjectOne.Common;

namespace ProjectOne.Data
{
    public class ProgramData
    {
        public List<Students> GetAllStudents()
        {
            List<Students> students = new List<Students>();

            SqlConnection connection = Database.GetConnection();
            connection.Open();

            using (connection)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM STUDENTS", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) //(int id, int number, string name, string surname,int classNumber, double grade)
                {
                    Students student = new Students();
                    student.Id = reader.GetInt32(0);

                    if (!reader.IsDBNull(1))
                    {
                        student.Name = reader.GetString(1);
                    }
                    if (!reader.IsDBNull(2))
                    {
                        student.Number = reader.GetInt32(2);
                    }
                    if (!reader.IsDBNull(3))
                    {
                        student.Name = reader.GetString(3);
                    }
                    if (!reader.IsDBNull(4))
                    {
                        student.Surname = reader.GetString(4);
                    }
                    if (!reader.IsDBNull(5))
                    {
                        student.ClassNumber = reader.GetInt32(5);
                    }
                    if (!reader.IsDBNull(6))
                    {
                        student.Grade = reader.GetDouble(6);
                    }
                    students.Add(student);
                }
            }
            return students;

        }

        public Students GetAllStudentsByClass(int classNumber)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();
            Students student = new Students();

            using (connection)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Students WHERE classNumber=@classNumber", connection);
                command.Parameters.AddWithValue("@classNumber", classNumber);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    student.Id = reader.GetInt32(0);
                    if (!reader.IsDBNull(1))
                    {
                        student.Name = reader.GetString(1);
                    }
                    if (!reader.IsDBNull(2))
                    {
                        student.Number = reader.GetInt32(2);
                    }
                    if (!reader.IsDBNull(3))
                    {
                        student.Name = reader.GetString(3);
                    }
                    if (!reader.IsDBNull(4))
                    {
                        student.Surname = reader.GetString(4);
                    }
                    if (!reader.IsDBNull(5))
                    {
                        student.ClassNumber = reader.GetInt32(5);
                    }
                    if (!reader.IsDBNull(6))
                    {
                        student.Grade = reader.GetDouble(6);
                    }
                }
            }
            return student;
        }

        public void AddStudent (Students student)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();

            using (connection)
            {
                SqlCommand command = new SqlCommand("INSERT INTO Students (Id, Number, Name, Surname, ClassNumber, Grade) " +
                    "VALUES (@id, @number, @name, @surname, @classNumber, @grade)", connection);
                command.Parameters.AddWithValue("@id", student.Id);
                command.Parameters.AddWithValue("@number", student.Number);
                command.Parameters.AddWithValue("@name", student.Name);
                command.Parameters.AddWithValue("@surname", student.Surname);
                command.Parameters.AddWithValue("@classNumber", student.ClassNumber);
                command.Parameters.AddWithValue("@grade", student.Grade);

                command.ExecuteNonQuery();
            }
           
        }

        public void AddTeacher( Teachers teacher)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();

            using (connection)
            {
                SqlCommand command = new SqlCommand("INSERT INTO Teachers (Id, Name, Surname, ClassNumber, Exam) " +
                   "VALUES (@id, @name, @surname, @classNumber, @exam)", connection);

                command.Parameters.AddWithValue("@id", teacher.Id);
                command.Parameters.AddWithValue("@number", teacher.Name);
                command.Parameters.AddWithValue("@name", teacher.Surname);
                command.Parameters.AddWithValue("@surname", teacher.ClassNumber);
                command.Parameters.AddWithValue("@classNumber", teacher.Exam);

                command.ExecuteNonQuery();

            }
        }

        public void AddExam(Exams exam)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();

            using (connection)
            {
                SqlCommand command = new SqlCommand("INSERT INTO Exams (Subject, ClassNumber, Time) " +
                   "VALUES (@subject @classNumber, @time)", connection);

                command.Parameters.AddWithValue("@id", exam.Subject);
                command.Parameters.AddWithValue("@number", exam.ClassNumber);
                command.Parameters.AddWithValue("@name", exam.Time);
               
                command.ExecuteNonQuery();

            }
        }

        public void DeleteStudent (int id)
        {
            SqlConnection connection = Database.GetConnection();
            connection.Open();

            using (connection)
            {
                SqlCommand command = new SqlCommand("DELETE Students WHERE id=@id", connection);
                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }
        }


    }
}
