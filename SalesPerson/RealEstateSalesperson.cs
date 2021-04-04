using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPerson
{
    class RealEstateSalesperson : Salesperson
    {
        double totalValue = 0;
        double totalCommission = 0;
        double commissionRate;

        public double TotalValue
        {
            get { return totalValue; }
            set { totalValue = value; }
        }
        public double TotalCommission
        {
            get { return totalCommission; }
            set { totalCommission = value; }
        }
        public double CommissionRate { 
            get { return commissionRate; }
            set { commissionRate = value; } 
        }

        public RealEstateSalesperson
            (string firstName,
            string lastName,
            double commissionRate) : base(firstName, lastName)
        {
            CommissionRate = commissionRate;
        }

        public void SalesSpeech()
        {
            Console.WriteLine($"{base.ToString()}Commission Rate: {CommissionRate}\nTotal Value: {TotalValue}\nTotal Commissions: {TotalCommission}\n");
        }

        public void MakeSale(int houseValue)
        {
            TotalValue += houseValue;
            TotalCommission += (CommissionRate/100) * TotalValue;
        }
    }
}
