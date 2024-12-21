using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        // Tạo danh sách học sinh và điền thông tin vào
        List<Student> students = new List<Student>
        {
            new Student(1, "An", 16),
            new Student(2, "Anh", 14),
            new Student(3, "Huy", 18),
            new Student(4, "Don", 20),
            new Student(5, "Hiep", 17)
        };

        // a. In toàn bộ danh sách học sinh
        Console.WriteLine("Danh sach toan bo hoc sinh:");
        foreach (var student in students)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // b. Tìm và in danh sách học sinh có tuổi từ 15 đến 18
        var ageFilter = students.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
        Console.WriteLine("\nHoc sinh co tuoi tu 15 den 18:");
        foreach (var student in ageFilter)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // c. Tìm và in học sinh có tên bắt đầu bằng chữ "A"
        var nameFilter = students.Where(s => s.Name.StartsWith("A")).ToList();
        Console.WriteLine("\nHoc sinh co ten bat dau bang chu 'A':");
        foreach (var student in nameFilter)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // d. Tính tổng tuổi của tất cả học sinh
        var totalAge = students.Sum(s => s.Age);
        Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh: {totalAge}");

        // e. Tìm và in học sinh có tuổi lớn nhất
        var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
        Console.WriteLine($"\nHoc sinh co so tuoi lon nhat: Id: {oldestStudent?.Id}, Name: {oldestStudent?.Name}, Age: {oldestStudent?.Age}");

        // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra
        var sortedStudents = students.OrderBy(s => s.Age).ToList();
        Console.WriteLine("\nDanh sach hoc sinh sap xep theo tuoi tang dan:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
    }
}
