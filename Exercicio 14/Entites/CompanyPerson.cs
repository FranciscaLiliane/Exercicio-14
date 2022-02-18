using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_14.Entites
{
    class CompanyPerson : Person
    {
        public int NumberEmploees { get; set; }
        public CompanyPerson(string name, double annualIncome, int numberEmployees) : base(name, annualIncome)
        {
            NumberEmploees = numberEmployees;
        }

        public override double calculateTax()
        {
            if(NumberEmploees > 10)
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }
    }
}
