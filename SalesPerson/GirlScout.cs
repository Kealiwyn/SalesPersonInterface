using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPerson
{
    class GirlScout : Salesperson
    {
        int cookiesSold = 0;
        public int CookiesSold
        {
            get { return cookiesSold; }
            set { cookiesSold = value; }
        }


        public GirlScout(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        public void SalesSpeech()
        {
            Console.WriteLine($"{base.ToString()}Number of Boxes sold: {cookiesSold}\n");
        }

        public void MakeSale(int boxesSold)
        {
            CookiesSold += boxesSold;
        }
    }
}
