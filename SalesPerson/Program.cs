using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            RealEstateSalesperson agent01 = new RealEstateSalesperson("Bob","Marley", 10);
            agent01.SalesSpeech();
            agent01.MakeSale(150000);
            agent01.SalesSpeech();

            Console.WriteLine("=============================================\n");

            GirlScout scout = new GirlScout("leroy", "jenkins");
            scout.SalesSpeech();
            scout.MakeSale(10);
            scout.SalesSpeech();


            Console.ReadKey();
        }
    }
}
