using System;
using System.Collections;

namespace InternshipGenerics7ForHome1
{
    class Student : Person
    {
        readonly ArrayList marks;

        public Student()
        {
            marks = new ArrayList();
        }

        public void AddMark(object mark)
        {
            marks.Add(mark);
        }

        //Show the student's average marks in the Console
        public void GetAVG() 
        {
            throw new NotImplementedException("Calculation of the average marks is not implemented");
        }

        //Show the student's marks in the Console
        public void ShowMarks()
        {
            throw new NotImplementedException("ShowMarks() is not implemented");
        }
    }
}
