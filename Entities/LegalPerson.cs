using ExercPropMetAbstracts.Entities;

namespace ExercPropMetAbstracts.Entities
{
    class LegalPerson : Person
    {
        public double NumberOfEmployees { get; set; }

        public LegalPerson(string name, double anualIncome, double numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double TaxPaid()
        {
            if (NumberOfEmployees <= 10)
            {
                return (AnualIncome * 0.16);
            }
            else
            {
                return (AnualIncome * 0.14);
            }
        }
    }
}
