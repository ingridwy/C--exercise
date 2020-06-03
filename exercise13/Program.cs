using System;

namespace exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            Teachers teachers = new Teachers();
            teachers.TeachFrench();
            SportTeachers sportTeachers = new SportTeachers();
            sportTeachers.TeachFrench();
        }
    }
}
