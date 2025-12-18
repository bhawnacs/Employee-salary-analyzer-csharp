using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_salary_analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of employees: ");
            int n = int.Parse(Console.ReadLine());

            string[] names = new string[n];
            int[] salaries = new int[n];

            int totalSalary = 0;

            Console.WriteLine("\nEnter employee details:");

            for (int i = 0; i < n; i++)
            {
                Console.Write("Employee Name: ");
                names[i] = Console.ReadLine();

                Console.Write("Salary: ");
                salaries[i] = int.Parse(Console.ReadLine());

                totalSalary += salaries[i];
                Console.WriteLine();
            }

            int maxSalary = salaries[0];
            int minSalary = salaries[0];
            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 1; i < n; i++)
            {
                if (salaries[i] > maxSalary)
                {
                    maxSalary = salaries[i];
                    maxIndex = i;
                }

                if (salaries[i] < minSalary)
                {
                    minSalary = salaries[i];
                    minIndex = i;
                }
            }

            double averageSalary = (double)totalSalary / n;

            Console.WriteLine("Salary Analysis");
            Console.WriteLine("------------------");
            Console.WriteLine("Total Salary: " + totalSalary);
            Console.WriteLine("Average Salary: " + averageSalary);
            Console.WriteLine("Highest Salary: " + maxSalary + " (" + names[maxIndex] + ")");
            Console.WriteLine("Lowest Salary: " + minSalary + " (" + names[minIndex] + ")");


        }
    }
}
