
using System;
using System.Collections.Generic;
using System.Linq;
 
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public int percentage { get; set; }
    // Other properties...

    public static List<Student> GetSampleData()
    {
        return new List<Student>
        {
            new Student { Id = 1, Name = "Ashish", Gender = "Male", percentage = 90},
            new Student { Id = 2, Name = "jishan", Gender = "Male", percentage = 80},
            new Student { Id = 3, Name = "Charvi", Gender = "Female", percentage = 70},
            new Student { Id = 4, Name = "Rakhi", Gender = "Female", percentage = 90},
        };
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = Student.GetSampleData();

        // Filtering students by gender
        var females = students.Where(s => s.Gender == "Female");

        // Grouping students by gender
        var groupedByGender = students.GroupBy(s => s.Gender);

        // Calculating the sum of student IDs
        var sumOfIds = students.Sum(s => s.Id);

        // Checking if the list contains a specific name
        bool containsRam = students.Any(s => s.Name == "Ram");

        // Ordering students by name
        var orderedByName = students.OrderBy(s => s.Name);

        // Displaying results
        Console.WriteLine("Females:");
        foreach (var female in females)
        {
            Console.WriteLine($"{female.Name} - {female.Gender}");
        }

        Console.WriteLine("\nGrouped by Gender:");
        foreach (var group in groupedByGender)
        {
            Console.WriteLine($"{group.Key}: {string.Join(", ", group.Select(s => s.Name))}");
        }

        Console.WriteLine($"\nSum of Student IDs: {sumOfIds}");

        Console.WriteLine($"\nContains 'Ram': {containsRam}");

        Console.WriteLine("\nOrdered by Name:");
        foreach (var student in orderedByName)
        {
            Console.WriteLine($"{student.Name} - {student.Gender}");
        }
    }
}






















































/*
using System;
using System.Collections.Generic;
using System.Linq;
 
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Percentage { get; set; }

    public static List<Student> GetSampleData()
    {
        return new List<Student>
        {
            new Student { Id = 1, Name = "Ashish", Gender = "Male", Percentage = 90},
            new Student { Id = 2, Name = "Jishan", Gender = "Male", Percentage = 80},
            new Student { Id = 3, Name = "Charvi", Gender = "Female", Percentage = 70},
            new Student { Id = 4, Name = "Rakhi", Gender = "Female", Percentage = 90},
        };
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = Student.GetSampleData();

        // Example of using join to combine data from two sources
        var joinedData = from student in students
                         join otherData in GetAdditionalData() on student.Id equals otherData.StudentId
                         select new
                         {
                             student.Id,
                             student.Name,
                             student.Gender,
                             student.Percentage,
                             otherData.AdditionalProperty
                         };

        // Displaying joined data
        Console.WriteLine("Joined Data:");
        foreach (var data in joinedData)
        {
            Console.WriteLine($"{data.Id} - {data.Name} - {data.Gender} - {data.Percentage} - {data.AdditionalProperty}");
        }
    }

    // Additional method providing sample data for the second source
    static List<AdditionalData> GetAdditionalData()
    {
        return new List<AdditionalData>
        {
            new AdditionalData { StudentId = 1, AdditionalProperty = "Property A" },
            new AdditionalData { StudentId = 2, AdditionalProperty = "Property B" },
            new AdditionalData { StudentId = 3, AdditionalProperty = "Property C" },
            new AdditionalData { StudentId = 4, AdditionalProperty = "Property D" },
        };
    }
}

// Additional class for the second source
class AdditionalData
{
    public int StudentId { get; set; }
    public string AdditionalProperty { get; set; }
}

*/