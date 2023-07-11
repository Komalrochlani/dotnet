// See https://aka.ms/new-console-template for more information
using LMS;

Console.WriteLine("Hello, World!");


DateTime regDate=new DateTime(2023,04,18);
DateTime birthDate=new DateTime(1990,04,18);
Student s1 = new Student(23,"pgdac",regDate,"Raj","Verma","473874837",34,birthDate);

Console.WriteLine(s1);