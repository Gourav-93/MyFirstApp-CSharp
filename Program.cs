// Student s1 = new Student();

// s1.Id = 1;
// s1.Name = "Gourav";
// s1.Age = 22;
// s1.company = "Winlancer inten";

// Console.WriteLine("Student Id: " + s1.Id);
// Console.WriteLine("Student Name: " + s1.Name);
// Console.WriteLine("Student Age: " + s1.Age);
// Console.WriteLine("Student company  : " + s1.company);


List<Student> students = new List<Student>();

Student s1 = new Student();
s1.Id = 1;
s1.Name = "Gourav";
s1.Age = 22;
s1.company = "Winlancer inten";

Student s2 = new Student();
s2.Id = 2;
s2.Name = "Nikunj";
s2.Age = 21;
s2.company = "TCS";

Student s3 = new Student();
s3.Id = 3;
s3.Name = "Amit";
s3.Age = 23;
s3.company = "Google";

students.Add(s1);
students.Add(s2);
students.Add(s3);

foreach (Student student in students)
{
    Console.WriteLine("Id: " + student.Id);
    Console.WriteLine("Name: " + student.Name);
    Console.WriteLine("Age: " + student.Age);
    Console.WriteLine("Company: " + student.company);
    Console.WriteLine("----------------");
}


