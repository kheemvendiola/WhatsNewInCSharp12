
//collection expression
Student[] batch1 = [];
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Enter name for Student {i + 1}:");
    var name = Console.ReadLine();
    
    Console.WriteLine($"Enter grade for Student {i + 1}:");
    var gradeInput = Console.ReadLine();
    
    if (!double.TryParse(gradeInput, out double grade))
    {
        Console.WriteLine("Not a valid input. Skipping..");
        continue;
    }

    //spread operator
    batch1 = [.. batch1, new Student(name, grade)];
}

foreach (var student in batch1)
{
    //default lambda parameters
    var studentPassed = (double grade, string name, int bonus = 5) => $"Student {name} {(grade + bonus > 75 ? "Passed" : "Failed")}";
    Console.WriteLine(studentPassed(student.Grade, student.Name));
}



//primary constructor
class Student(string name, double grade)
{
    public string Name => name;
    public double Grade => grade;
}