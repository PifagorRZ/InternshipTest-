using System.Collections.Generic;
using InternshipTest.Person;
using System;

namespace InternshipTest.Institution.InterLink

{
    public class Internship
    {
        public string Name { get; }
        private List<Student> interns = new List<Student>();

        public Internship(string name)
        {
            Name = name;      
        }

        public void AddStudents(List<Student> students)
        {
            interns.AddRange(GetStudentsWithGoodKnowledge(students));
        }

        public string GetStudents()
        {
            string internNames = "";

            foreach (Student intern in interns)
            {
                internNames += intern.name + "\n";
            }

            return internNames;
        }

        //¬озможно реализаци€ не сама€ лучша€, и тут можно были сделать все через LINQ (который € не знаю) в 1 строчку,
        //но зато работает)) а то € уже привык к JS, и теперь C# выгр€дит как-то странно)
        private List<Student> GetStudentsWithGoodKnowledge(List<Student> students)
        {
            int averageValue = 0;
            List<Student> congruentStudents = new List<Student>();

            foreach (Student student in students)
            {
                averageValue += student.Knowledge.Level;
            }
            averageValue /= students.Count;

            foreach (Student student in students)
            {
                if (student.Knowledge.Level > averageValue)
                {
                    congruentStudents.Add(student);
                }
            }

            return congruentStudents;
        }
    }
}
