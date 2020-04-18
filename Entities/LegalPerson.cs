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

        public override double TaxPaid(double anualIncome)
        {
            if (NumberOfEmployees <= 10)
            {
                return (anualIncome * 0.16);
            }
            else
            {
                return (anualIncome * 0.14);
            }
        }
    }
}
