using System;
using Homework19._4._2022.Models;

namespace Homework19._4._2022

{
    class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee
            {
                FullName = "Nicat Muxtarov",
                Position = "Student",
                Salary = 5000
            };
            Employee em1 = new Employee
            {
                FullName = "Seid Zaidov",
                Position = "Student",
                Salary = 5000
            };
            Employee em2 = new Employee
            {
                FullName = "Ilkin Rzayev",
                Position = "Student",
                Salary = 5000
            };

            Company cm = new Company();
            cm.Name = "EA Games";
            cm.Limit = 3;
            cm.AddEmoployee(em);
            cm.AddEmoployee(em1);
            cm.AddEmoployee(em2);
            foreach (Employee item in cm.GetEmployee())
            {
                Console.WriteLine($"Name: {item.FullName} Salary: {item.Salary} Position {item.Position} Number: {item.No}");
            }
        }
    }
}
