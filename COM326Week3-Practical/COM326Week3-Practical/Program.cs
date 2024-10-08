using COM326Week3_Practical;
using StudentLibrary;

class Program
{
    static Program program = new Program();

    static void Main(String[] args)
    {
        program.Challenge1();
        program.Challenge2();
    }

    void Challenge1()
    {
        Student student1 = new Student();
        student1.Display();
        Student student2 = new Student("Callum", 18);
        student2.Display();
    }

    void Challenge2()
    {
        Book book1 = new Book();
        book1.Display();
        Book book2 = new Book("Example book", "Example author", "Example genre", "2024", "Example publisher");
        book2.Display();
    }
}
