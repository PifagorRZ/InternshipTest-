using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student("Alex");
            s.SetKnowledge(new Knowledge(75));
            var v = new Student("Kate");
            v.SetKnowledge(new Knowledge(60));
            var t = new Student("Mili");
            t.SetKnowledge(new Knowledge(90));
            var d = new Student("Oleg");
            d.SetKnowledge(new Knowledge(10));

            University university = new University("CH.U.I.");

            university.AddStudent(s);
            university.AddStudent(v);
            university.AddStudent(t);
            university.AddStudent(d);

            Internship internship = new Internship("Interlink");
            //сюда можно передвать любой список студентов, даже з бд или файла
            internship.AddStudents(university.students);
            internship.AddStudents(university.students);

            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());
            Console.ReadKey();
        }
    }
}
