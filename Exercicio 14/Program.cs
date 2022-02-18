using Exercicio_14.Entites;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> list = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new IndividualPerson(name, annualIncome, healthExpenditures));
                }
                else if (ch == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());
                    list.Add(new CompanyPerson(name, annualIncome, numberEmployees));
                }
            }
            double totalTaxes = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (Person person in list)
            {
                Console.WriteLine(person.Name+": $ "+person.calculateTax().ToString("F2",CultureInfo.InvariantCulture));
                totalTaxes += person.calculateTax();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ "+totalTaxes);
        }
    }
}
