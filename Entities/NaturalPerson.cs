using ExercPropMetAbstracts.Entities;

namespace ExercPropMetAbstracts.Entities
{
    class NaturalPerson: Person
    {
        public double HealthExpenditures { get; set; }

        public NaturalPerson(string name, double anualIncome, double healthExpenditures): base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxPaid()
        {
            if (AnualIncome < 20000.0)
            {
                return (AnualIncome * 0.15);
            }
            else
            {
                return ((AnualIncome * 0.25) - (HealthExpenditures * 0.50));
            }
        }
    }
}
