using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipGenerics7ForHome1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create students
            var tomWhite = new Student() 
            { 
                Firstname = "Tom",
                LasName = "White"
            };

            var annaSmith = new Student()
            {
                Firstname = "Anna",
                LasName = "Smith"
            };


            //create the students group
            var groupInformatics10 = new StudentsGroup()
            {
                Name = "Informatics 10",
            };


            //Add students to the student group
            groupInformatics10.AddStudent(tomWhite);
            groupInformatics10.AddStudent(annaSmith);


            //Add marks   
            tomWhite.AddMark(10);
            tomWhite.AddMark(7);
            tomWhite.AddMark(7);
            tomWhite.AddMark(9);
            tomWhite.AddMark(8);

            annaSmith.AddMark(8);
            annaSmith.AddMark(8);
            annaSmith.AddMark(10);
            annaSmith.AddMark(9);
            annaSmith.AddMark(10);


            //Show how many students are in the group
            groupInformatics10.Count();

            //Show the info of all students (firstname, lastname, average marks) in the Console
            //example:
            //Anna Smith - 9.0
            //Tom White - 8.5
            groupInformatics10.ShowAllStudentsInfo();

            Console.ReadLine();
        }
    }
}
