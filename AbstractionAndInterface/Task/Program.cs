namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group1 = new Group(1, "655.20");
            Group group2 = new Group(2, "651.20");
            Student student1 = new Student(1, "Ferid", "Adgozelov");
            Student student2 = new Student(2, "Huseyn", "Huseynov");
            Student student3 = new Student(3, "Araz", "Merdanov");
            Student student4 = new Student(4, "Rauf", "Ehmedli");
            group1.AddStudent(student1);
            group1.AddStudent(student2);
            group1.AddStudent(student3);
            group1.RemoveStudent(student2);
            group1.RemoveStudent(student3);
            group2.AddStudent(student4);
            group1.GetStudents();

        }
    }
}