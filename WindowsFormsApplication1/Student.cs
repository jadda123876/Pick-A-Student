using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    //student class is for storing the data associated with individual students (name and scores)
    public class Student
    {
        public String name;
        public String correctScore;
        public String incorrectScore;
        public String absentScore;

        //no arg constructor
        public Student()
        {
            name = "";
            correctScore = "0";
            incorrectScore = "0";
            absentScore = "0";
        }

        //full constructor
        public Student(String name, String c, String i, String a)
        {
            setName(name);
            setCorrect(c);
            setIncorrect(i);
            setAbsent(a);
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setCorrect(String c)
        {
            correctScore = c;
        }

        public void setIncorrect(String i)
        {
            incorrectScore = i;
        }

        public void setAbsent(String a)
        {
            absentScore = a;
        }

    }
}
