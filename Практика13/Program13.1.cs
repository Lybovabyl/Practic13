using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр13._1
{
   
    
        
public class Employee
        {
            public string Name { get; set; }
            public string Position { get; set; }
            public decimal Salary { get; set; }
            public DateTime HireDate { get; set; }

            
            public Employee(string name, string position, decimal salary, DateTime hireDate)
            {
                Name = name;
                Position = position;
                Salary = salary;
                HireDate = hireDate;
            }

           
            public void DisplayInfo()
            {
                Console.WriteLine($"Имя: {Name}");
                Console.WriteLine($"Должность: {Position}");
                Console.WriteLine($"Зарплата: {Salary}");
                Console.WriteLine($"Дата приема: {HireDate.ToShortDateString()}");
            }
        }

        
        public class Manager : Employee
        {
            public int TeamSize { get; set; }

            public Manager(string name, string position, decimal salary, DateTime hireDate, int teamSize)
                : base(name, position, salary, hireDate)
            {
                TeamSize = teamSize;
            }

            public void ConductMeeting()
            {
                Console.WriteLine($"{Name} проводит собрание с командой из {TeamSize} человек.");
            }
        }

        
        public class Developer : Employee
        {
            public string ProgrammingLanguage { get; set; }

            public Developer(string name, string position, decimal salary, DateTime hireDate, string programmingLanguage)
                : base(name, position, salary, hireDate)
            {
                ProgrammingLanguage = programmingLanguage;
            }

            public void WriteCode()
            {
                Console.WriteLine($"{Name} пишет код на {ProgrammingLanguage}.");
            }
        }

        
        public class Director : Employee
        {
            public string Department { get; set; }

            public Director(string name, string position, decimal salary, DateTime hireDate, string department)
                : base(name, position, salary, hireDate)
            {
                Department = department;
            }

            public void ApproveBudget()
            {
                Console.WriteLine($"{Name} утверждает бюджет отдела {Department}.");
            }
        }

        
        class Program
        {
            static void Main()
            {
                Employee employee = new Employee("Влад Пронин", "Рядовой сотрудник", 27000, DateTime.Parse("2022-08-27"));
                employee.DisplayInfo();

                Console.WriteLine();

                Manager manager = new Manager("Алекса Деми", "Менеджер", 45000, DateTime.Parse("2021-05-10"), 4);
                manager.DisplayInfo();
                manager.ConductMeeting();

                Console.WriteLine();

                Developer developer = new Developer("Артем Кошман", "Разработчик", 234600, DateTime.Parse("2022-09-03"), "c#");
                developer.DisplayInfo();
                developer.WriteCode();

                Console.WriteLine();

                Director director = new Director("Полина Гухман", "Директор", 150000, DateTime.Parse("2018-06-13"), "Разработки");
                director.DisplayInfo();
                director.ApproveBudget();
            }
        }
    }


    

