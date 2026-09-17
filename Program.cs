// Student s1 = new Student();

// s1.Id = 1;
// s1.Name = "Gourav";
// s1.Age = 22;
// s1.company = "Winlancer inten";

// Console.WriteLine("Student Id: " + s1.Id);
// Console.WriteLine("Student Name: " + s1.Name);
// Console.WriteLine("Student Age: " + s1.Age);
// Console.WriteLine("Student company  : " + s1.company);



// List<Student> students = new List<Student>();

// Student s1 = new Student();
// s1.Id = 1;
// s1.Name = "Gourav";
// s1.Age = 22;
// s1.company = "Winlancer inten";

// Student s2 = new Student();
// s2.Id = 2;
// s2.Name = "Nikunj";
// s2.Age = 21;
// s2.company = "TCS";

// Student s3 = new Student();
// s3.Id = 3;
// s3.Name = "Amit";
// s3.Age = 23;
// s3.company = "Google";

// students.Add(s1);
// students.Add(s2);
// students.Add(s3);

// foreach (Student student in students)
// {
//     Console.WriteLine("Id: " + student.Id);
//     Console.WriteLine("Name: " + student.Name);
//     Console.WriteLine("Age: " + student.Age);
//     Console.WriteLine("Company: " + student.company);
//     Console.WriteLine("----------------");
// }



// List<Student> students = new List<Student>();

// Console.Write("Enter Student Id: ");
// int id = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter Student Name: ");
// string name = Console.ReadLine() ?? "";

// Console.Write("Enter Student Age: ");
// int age = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter Company: ");
// string company = Console.ReadLine() ?? "";

// Student student = new Student();

// student.Id = id;
// student.Name = name;
// student.Age = age;
// student.company = company;

// students.Add(student);

// Console.WriteLine("\n--- Student Details ---");

// foreach (Student s in students)
// {
//     Console.WriteLine("Id: " + s.Id);
//     Console.WriteLine("Name: " + s.Name);
//     Console.WriteLine("Age: " + s.Age);
//     Console.WriteLine("Company: " + s.company);
// }



// List<Student> students = new List<Student>();

// while (true)
// {
//     Console.WriteLine("\n===== Student Management System =====");
//     Console.WriteLine("1. Add Student");
//     Console.WriteLine("2. View Students");
//     Console.WriteLine("3. Exit");

//     Console.Write("Enter your choice: ");
//     int choice = Convert.ToInt32(Console.ReadLine());

//     if (choice == 1)
//     {
//         Console.Write("\nEnter Student Id: ");
//         int id = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Enter Student Name: ");
//         string name = Console.ReadLine() ?? "";

//         Console.Write("Enter Student Age: ");
//         int age = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Enter Company: ");
//         string company = Console.ReadLine() ?? "";

//         Student student = new Student();

//         student.Id = id;
//         student.Name = name;
//         student.Age = age;
//         student.company = company;

//         students.Add(student);

//         Console.WriteLine("\nStudent added successfully!");
//     }
//     else if (choice == 2)
//     {
//         Console.WriteLine("\n===== Student List =====");

//         if (students.Count == 0)
//         {
//             Console.WriteLine("No students found.");
//         }
//         else
//         {
//             foreach (Student s in students)
//             {
//                 Console.WriteLine("----------------");
//                 Console.WriteLine("Id: " + s.Id);
//                 Console.WriteLine("Name: " + s.Name);
//                 Console.WriteLine("Age: " + s.Age);
//                 Console.WriteLine("Company: " + s.company);
//             }
//         }
//     }
//     else if (choice == 3)
//     {
//         Console.WriteLine("Thank you!");
//         break;
//     }
//     else
//     {
//         Console.WriteLine("Invalid choice!");
//     }
// }

List<Student> students = new List<Student>();

while (true)
{
    Console.WriteLine("\n===== Student Management System =====");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. View Students");
    Console.WriteLine("3. Search Student");
    Console.WriteLine("4. Exit");

    Console.Write("Enter your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {
        AddStudent();
    }
    else if (choice == 2)
    {
        ViewStudents();
    }
    else if (choice == 3)
    {
        SearchStudent();
    }
    else if (choice == 4)
    {
        DeleteStudent();
    }
    else if (choice == 5)
    {
        Console.WriteLine("Thank you!");
        break;
    }
    else
    {
        Console.WriteLine("Invalid choice!");
    }
}

void AddStudent()
{
    Console.Write("\nEnter Student Id: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter Student Name: ");
    string name = Console.ReadLine() ?? "";

    Console.Write("Enter Student Age: ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter Company: ");
    string company = Console.ReadLine() ?? "";

    Student student = new Student();

    student.Id = id;
    student.Name = name;
    student.Age = age;
    student.company = company;

    students.Add(student);

    Console.WriteLine("Student added successfully!");
}

void ViewStudents()
{
    Console.WriteLine("\n===== Student List =====");

    if (students.Count == 0)
    {
        Console.WriteLine("No students found.");
        return;
    }

    foreach (Student s in students)
    {
        Console.WriteLine("----------------");
        Console.WriteLine("Id: " + s.Id);
        Console.WriteLine("Name: " + s.Name);
        Console.WriteLine("Age: " + s.Age);
        Console.WriteLine("Company: " + s.company);
    }
}

void SearchStudent()
{
    Console.Write("\nEnter Student Id to search: ");
    int id = Convert.ToInt32(Console.ReadLine());

    bool found = false;

    foreach (Student s in students)
    {
        if (s.Id == id)
        {
            Console.WriteLine("\nStudent Found!");
            Console.WriteLine("Id: " + s.Id);
            Console.WriteLine("Name: " + s.Name);
            Console.WriteLine("Age: " + s.Age);
            Console.WriteLine("Company: " + s.company);

            found = true;
            break;
        }
    }

    if (!found)
    {
        Console.WriteLine("Student not found!");
    }
}
void DeleteStudent()
{
    Console.Write("\nEnter Student Id to delete: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Student? studentToDelete = null;

    foreach (Student s in students)
    {
        if (s.Id == id)
        {
            studentToDelete = s;
            break;
        }
    }

    if (studentToDelete != null)
    {
        students.Remove(studentToDelete);
        Console.WriteLine("Student deleted successfully!");
    }
    else
    {
        Console.WriteLine("Student not found!");
    }
}