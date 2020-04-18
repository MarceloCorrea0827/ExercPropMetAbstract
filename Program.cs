using System.Collections.Generic;
using System.Globalization;
using System;
using ExercPropMetAbstracts.Entities;

namespace ExercPropMetAbstracts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPerson = new List<Person>();

            System.Console.Write("Enter the number of tax payers: ");
            int numTaxPayers = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numTaxPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company (i/c): ");
                char typePerson = char.Parse(Console.ReadLine());
                if (typePerson == 'i' || typePerson == 'I')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    listPerson.Add(new NaturalPerson(name, anualIncome, healthExpenditures));
                }
                else // Sem tratamento da entrada. Ambiente de testes controlado.
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int numberOfEmplyees = int.Parse(Console.ReadLine());

                    listPerson.Add(new LegalPerson(name, anualIncome, numberOfEmplyees));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach(Person person in listPerson)
            {
                Console.WriteLine(person.Name + ": $" + person.TaxPaid().ToString("F2",CultureInfo.InvariantCulture));
            }

            double sum = 0;
            foreach (Person person in listPerson)
            {
                sum += person.TaxPaid();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $" + sum.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
