using System;
using System.Collections.Generic;



// Interface
interface IPayroll
{
    double CalculateSalary();
}

// Base Class
class Employee
{
    public int EmpId;
    public string Name;

    public Employee(int id, string name)
    {
        EmpId = id;
        Name = name;
    }

    public virtual void Display()
    {
        Console.WriteLine("\nEmployee ID   : " + EmpId);
        Console.WriteLine("Employee Name : " + Name);
    }
}

// Derived Class - Permanent Employee
class PermanentEmployee : Employee, IPayroll
{
    public double BasicSalary;

    public PermanentEmployee(int id, string name, double salary)
        : base(id, name)
    {
        BasicSalary = salary;
    }

    public double CalculateSalary()
    {
        double HRA = BasicSalary * 0.20;
        double DA = BasicSalary * 0.10;

        return BasicSalary + HRA + DA;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Employee Type : Permanent");
        Console.WriteLine("Basic Salary  : " + BasicSalary);
        Console.WriteLine("Net Salary    : " + CalculateSalary());
    }
}

// Derived Class - Contract Employee
class ContractEmployee : Employee, IPayroll
{
    public int HoursWorked;
    public double RatePerHour;

    public ContractEmployee(int id, string name, int hours, double rate)
        : base(id, name)
    {
        HoursWorked = hours;
        RatePerHour = rate;
    }

    public double CalculateSalary()
    {
        return HoursWorked * RatePerHour;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Employee Type : Contract");
        Console.WriteLine("Hours Worked  : " + HoursWorked);
        Console.WriteLine("Rate/Hour     : " + RatePerHour);
        Console.WriteLine("Net Salary    : " + CalculateSalary());
    }
}

// Main Class
class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        Console.Write("Enter Number of Employees: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nEmployee " + (i + 1));
            Console.WriteLine("1. Permanent Employee");
            Console.WriteLine("2. Contract Employee");

            Console.Write("Enter Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            if (choice == 1)
            {
                Console.Write("Enter Basic Salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());

                employees.Add(new PermanentEmployee(id, name, salary));
            }
            else if (choice == 2)
            {
                Console.Write("Enter Hours Worked: ");
                int hours = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Rate Per Hour: ");
                double rate = Convert.ToDouble(Console.ReadLine());

                employees.Add(new ContractEmployee(id, name, hours, rate));
            }
            else
            {
                Console.WriteLine("Invalid Choice!");
                i--;
            }
        }

        Console.WriteLine("\n==============================");
        Console.WriteLine(" EMPLOYEE PAYROLL REPORT");
        Console.WriteLine("==============================");

        // Runtime Polymorphism
        foreach (Employee emp in employees)
        {
            emp.Display();
            Console.WriteLine("------------------------------");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}