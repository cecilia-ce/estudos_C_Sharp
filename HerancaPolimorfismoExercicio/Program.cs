using System;
using System.Collections.Generic;
using HerancaPolimorfismoExercicio.Entities;
using System.Globalization;

namespace HerancaPolimorfismoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees:");
            int n = int.Parse(Console.ReadLine());

            List<Employee> Employees = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee nº{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char option = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if(option == 'y')
                {
                    Console.Write("Additional charge: ");
                    double addCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employees.Add(new OutsourcedEmployee(name, hours, valuePH, addCharge));
                }
                else
                {
                    Employees.Add(new Employee(name, hours, valuePH));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee emp in Employees)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}
