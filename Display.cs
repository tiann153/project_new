using System;
using System.Collections.Generic;
using System.Text;
using ProjectOne.Business;
using ProjectOne.Common;

namespace ProjectOne.Presentation
{
    class Display
    {
        private bool running;
        private StudentsBusinessLogic studentsBusinessLogic;

        public Display(StudentsBusinessLogic studentsBusinessLogic)
        {
            this.running = true;
            this.studentsBusinessLogic = studentsBusinessLogic;
        }

        public void GetMenu()
        {
            while (running)
            {
                Console.WriteLine("--------- Menu ---------");
                Console.WriteLine("1. List all students");
                Console.WriteLine("2. Add new student");
                Console.WriteLine("3. Add new teacher");
                Console.WriteLine("4. Add new exam");
                Console.WriteLine("5. List a student by class number");
                Console.WriteLine("6. Delete student by ID");
                Console.WriteLine("7. Exit");

                EnterCommand();
            }
        }

        public void EnterCommand()
        {
            int command = int.Parse(Console.ReadLine());

            switch (command)
            {
                case 1:
                    this.GetAllStudents();
                    
                    break;
                case 2:
                    this.AddNewStudent();
                    break;
                case 3:
                    this.AddNewTeacher();
                    break;
                case 4:
                    this.AddNewExam();
                    break;
                case 5:
                    this.ListStudent();
                    break;
                case 6:
                    this.DeleteStudent();
                    break;
                default:
                    this.running = false;
                    break;



            }
        }

        private void DeleteStudent()
        {
            Console.WriteLine("--------- Delete student by id ---------");
            Console.WriteLine("Student id: ");
            int id = int.Parse(Console.ReadLine());

            this.studentsBusinessLogic.Delete(id);

        }

        private void ListStudent()
        {
            Console.WriteLine("--------- List students by id ---------");

            Console.WriteLine("Student id: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine(this.studentsBusinessLogic.GetAllStudentsByClass(id));
        }

        private void AddNewExam()
        {
            Console.WriteLine("--------- Add new exam ---------");

            Console.WriteLine("Exam subject:");
            string subject = Console.ReadLine();

            Console.WriteLine("Exam class number:");
            int classNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Exam time:");
            int time = int.Parse(Console.ReadLine());

            Exams exam = new Exams(subject, classNumber, time);
            this.studentsBusinessLogic.CreateExam(exam);
        }

        private void AddNewTeacher()
        {
            Console.WriteLine("--------- Add new teacher ---------");

            Console.WriteLine("Teacher id:");
            int id = int.Parse(Console.ReadLine());
           

            Console.WriteLine("Teacher Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Teacher Surname:");
            string surname = Console.ReadLine();

            Console.WriteLine("Teacher class number:");
            int classNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Teacher exam:");
            string exam = Console.ReadLine();

            Teachers teacher = new Teachers(id,  name, surname, classNumber, exam);
            this.studentsBusinessLogic.CreateTeacher(teacher);
        }

        private void AddNewStudent()
        {
            

            Console.WriteLine("--------- Add new student ---------");

            Console.WriteLine("Student id:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Student number in class:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Student Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Student Surname:");
            string surname = Console.ReadLine();

            Console.WriteLine("Student class number:");
            int classNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Student grade:");
            double grade = double.Parse(Console.ReadLine());

            Students student = new Students(id, number, name, surname, classNumber, grade);
            this.studentsBusinessLogic.CreateStudent(student);
        }

        private void GetAllStudents()
        {
            Console.WriteLine("--------- All students ---------");
            var students = studentsBusinessLogic.GetAllStudents();
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
