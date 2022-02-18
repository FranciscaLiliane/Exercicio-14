using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_14.Entites
{
    class IndividualPerson : Person
    {
        public double HealthExpenditures { get; set; }
        public IndividualPerson(string name, double annualIncome, double healthExpenditures) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double calculateTax()
        {
            return ((AnnualIncome * 0.25) - (HealthExpenditures * 0.5));
        }
    }
}
