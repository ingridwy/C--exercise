using System;

namespace exercise10
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;
        private string comment; 
        public Student(string aName, string aMajor,double aGpa, string aComment)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
            Comment = aComment;
        }
        public string Comment
        {
            get { return comment;}
            set { 
                if(value == "good" || value == "fair" || value == "unsatisfactory")
                {
                    comment = value;
                }
                else
                {
                    comment = "invalid";
                }
            }
        }
        public bool HasHonours()
        {
            if (gpa >= 3)
            {
                return true;
            }
            return false;
        }
    }
}
