enum StudentType
{
    Student, StudentLead, StudentSubLead
}
class Student
{
    private int m_course = 2;
    private string m_group = "K-24";
    public string m_name = "Vasya";
    protected bool m_accsessToDeanery = false;

    public Student() { }
    public Student(int  course, string group, string name)
    {
        this.m_course = course;
        this.m_group = group;
        this.m_name = name;
    }

    public static Student CreateStudent(StudentType studentType)
    {
        switch (studentType)
        {
            case StudentType.Student:
                return new Student();
            case StudentType.StudentLead:
                return new StudentLead();
            case StudentType.StudentSubLead:
                return new StudentSubLead();
            default: return new Student();
        }
    }

    public void showMainInfo()
    {
        Console.WriteLine($"Курс: {this.m_course}\nГрупа: {this.m_group}\nІм'я: {this.m_name}\n");
    }

    public virtual void showInfo()
    {
        showMainInfo();
    }
}

class StudentSubLead : Student
{
    public StudentSubLead() { }

    public override void showInfo()
    {
        showMainInfo();
        Console.WriteLine("Помічник");
    }

    public StudentSubLead(int course, string group, string name) : base(course, group, name) {}
}

class StudentLead : Student
{
    public override void showInfo()
    {
        showMainInfo();
        Console.WriteLine($"Дані старости:\nДоступ до деканату: {m_accsessToDeanery}");
    }
    public StudentLead() {
        this.m_accsessToDeanery=true;
    }

    public StudentLead(int course, string group, string name):base(course, group, name) {
        m_accsessToDeanery = true;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student();
        student.showInfo();

        StudentLead studentLead = new StudentLead(2, "K-23", "Любомир");
        studentLead.showInfo();

        StudentSubLead studentSubLead = new StudentSubLead(2, "K-23", "Ivan");
        studentSubLead.showInfo();

        Student student3 = Student.CreateStudent(StudentType.StudentLead);
        student3.showInfo();
    }
}
