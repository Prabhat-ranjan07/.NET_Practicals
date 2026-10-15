using System;
using System.Collections.Generic;

namespace ExpenseTrackingModule
{
    class Expense
    {
        public string Category { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }

        public Expense(string category, double amount, string description)
        {
            Category = category;
            Amount = amount;
            Description = description;
        }
    }

    class Program
    {
        static List<Expense> expenses = new List<Expense>();

        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n========== Expense Tracking System ==========");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. View Expenses");
                Console.WriteLine("3. Calculate Total Expense");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            AddExpense();
                            break;

                        case 2:
                            ViewExpenses();
                            break;

                        case 3:
                            TotalExpense();
                            break;

                        case 4:
                            Console.WriteLine("Thank you for using Expense Tracker.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice! Please try again.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid numeric choice.");
                    choice = 0;
                }

            } while (choice != 4);
        }

        static void AddExpense()
        {
            try
            {
                Console.Write("Enter Category: ");
                string category = Console.ReadLine();

                Console.Write("Enter Amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                if (amount <= 0)
                {
                    throw new Exception("Amount must be greater than zero.");
                }

                Console.Write("Enter Description: ");
                string description = Console.ReadLine();

                expenses.Add(new Expense(category, amount, description));

                Console.WriteLine("Expense added successfully.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid amount! Please enter numeric value.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Add Expense operation completed.");
            }
        }

        static void ViewExpenses()
        {
            if (expenses.Count == 0)
            {
                Console.WriteLine("No expenses available.");
                return;
            }

            Console.WriteLine("\n--------- Expense List ---------");

            foreach (Expense e in expenses)
            {
                Console.WriteLine("Category    : " + e.Category);
                Console.WriteLine("Amount      : ₹" + e.Amount);
                Console.WriteLine("Description : " + e.Description);
                Console.WriteLine("--------------------------------");
            }
        }

        static void TotalExpense()
        {
            double total = 0;

            foreach (Expense e in expenses)
            {
                total += e.Amount;
            }

            Console.WriteLine("Total Expense = " + total);
        }
    }
}