using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Classroom
    {
        public ArrayList myStudents = new ArrayList();
        public String name;

        public Classroom()
        {
        }
        public Classroom(String className){
            name = className;
        }

        //adds the student to the end of the list
        public void addStudent(Student theStudent)
        {
            myStudents.Add(theStudent);
        }

        //may be unnecessary if the class is reconstructed every time that a modification is made to the class, tbd
        public void removeStudent(int studentIndex)
        {
            myStudents.RemoveAt(studentIndex);
        }
    }
}
