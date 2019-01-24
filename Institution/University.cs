using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution
{
    public class University
    {
        public string Name { get; }
        public List<Student> students = new List<Student>();

        public University(string name)
        {
            Name = name;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
    }
}
