using System;
using System.Collections;

namespace InternshipGenerics7ForHome1
{
    class StudentsGroup 
    {
        public string Name { get; set; }

        readonly ArrayList students;

        public StudentsGroup()
        {
            students = new ArrayList();
        }

        public void AddStudent(object student)
        {
            students.Add(student);
        }

        //Show the info of all students (firstname, lastname, average marks) in the Console
        public void ShowAllStudentsInfo()
        {
            throw new NotImplementedException("ShowAllStudents() is not implemented");
        }

        //Show the number of students in the Console  (Firstname and Lastname)
        public void Count()
        {
            throw new NotImplementedException("Count() is not implemented");
        }
    }
}
