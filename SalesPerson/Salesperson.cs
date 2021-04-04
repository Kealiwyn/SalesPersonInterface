using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPerson
{
    abstract class Salesperson
    {
        protected string firstName;
        protected string lastName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public Salesperson(string firstName, string lastName) 
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"My name is {FirstName} {LastName} and I'm a {GetType()}\n";
        }


    }
}
