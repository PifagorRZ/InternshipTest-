namespace InternshipTest.Person
{
    public class Student
    {
        public Knowledge Knowledge { get; set; }
        readonly public string name;

        public Student(string name)
        {
            this.name = name;
        }

        public void SetKnowledge(Knowledge knowledge)
        {
            this.Knowledge = knowledge;
        }
    }
}