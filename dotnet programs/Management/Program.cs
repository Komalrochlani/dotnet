// See https://aka.ms/new-console-template for more information
using Hr;
using staff;

Console.WriteLine("Hello, World!");


Employee emp = new Employee("abc","xyz","abc@gmail",23);

Manager m = new Manager(2500,100,"komal","roc","komal@gmail",45);

Console.WriteLine(emp);
Console.WriteLine(m);

Console.WriteLine(m.ComputeSalary());