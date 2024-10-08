namespace StudentLibrary
{
    public class Student
    {
        private int id;
        private string name;
        private int age;
        private static int studentCount = 1;

        public int Id { get { return id; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public static int Count { get { return studentCount; } }

        public Student()
        {
            id = studentCount++;
            name = "John Doe";
            age = 16;
        }

        public Student(string name, int age)
        {
            this.id = studentCount++;
            this.name = name;
            this.age = age;
        }

        public int GetOlder()
        {
            return age++;
        }

        public void Display()
        {
            GetOlder();
            Console.WriteLine($"Id: {id}\nName: {name}\nAge: {age}");
        }
    }
}
