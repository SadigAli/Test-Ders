
namespace RefAndOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //int? a = null;
            //Nullable<int> b = null;
            //String str = null;
            //string str = null;
            //Console.WriteLine(default(int));
            //Console.WriteLine(default(string));

            //int num = 25;
            //int a;
            //Sum30(out a);
            //Console.WriteLine(a+20);
            //Student student = new Student(1, "Rauf");
            //Console.WriteLine(student.Name);
            //ChangeName(student);
            //Console.WriteLine(student.Name);
            //Console.WriteLine(num);
            //Sum10(ref num);
            //Console.WriteLine(num);

            //int[] nums = new int[] {1,3,5,2,5};
            //Array.Resize(ref nums, 6);
            //nums[5] = 25;
            //Console.WriteLine(nums[5]);

            Student[] students = new Student[]
            {
                new Student(1,"Araz","Merdanov"),
                new Student(2,"Rauf","Ehmedli"),
            };
            Array.Resize(ref students, 3);
            students[2] = new Student(3,"Huseyn","Huseynov");
            Array.Resize(ref students, 4);
            students[3] = new Student(4, "Ferid", "Adgozelov");

            foreach (Student student in students)
            {
                Console.WriteLine(student.GetFullName());
            }



        }
        static void Sum20(int num)
        {
            num += 20;
            Console.WriteLine(num);
        }

        static void Sum10(ref int num)
        {
            num += 10;
            Console.WriteLine(num);
        }

        static void Sum30(out int num)
        {
            num = 30;
            Console.WriteLine(num);
        }

        static void ChangeName(Student student)
        {
            student.Name = "Araz";
            Console.WriteLine(student.Name);
        }
    }
}