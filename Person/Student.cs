namespace InternshipTest.Person
{
    public class Student
    {
        public Knowledge Knowledge { get; set; }
        public string name { get; }

        public Student(string name)
        {
            this.name = name;
        }

        public void SetKnowledge(Knowledge knowledge)
        {
            Knowledge = knowledge;
        }
    }
}