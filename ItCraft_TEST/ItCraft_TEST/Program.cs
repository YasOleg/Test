using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItCraft_TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            PaidService[] arrPaidServices =
            {
                 new FixedHourlyCostPaidService("service1", "Google Orkut", 11),
                 new FixedHourlyCostPaidService("service2", "Google Voice", 9.4),
                 new FixedHourlyCostPaidService("service5", "YouTube", 8064),
                 new FixedHourlyCostPaidService("service3", "Mandrill", 11.2),
                 new FixedHourlyCostPaidService("service4", "Google Finance", 7.8),
                 new FixedMonthlyCostPaidService("service7", "Google Building Maker", 5347),
                 new FixedMonthlyCostPaidService("service6", "LinkedIn", 6863)            };

            var Task1 = arrPaidServices.OrderByDescending(e => e.calculateAverageMonthlyCosts(e.Costs));
           

            foreach (var item in Task1)
            {
                Console.WriteLine(item.Costs + "\t" + item.Id + "\t" + item.Name );
            }

            Console.WriteLine();

            var Task2 = Task1.Take(5);

            foreach (var item in Task2)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine();

            var Task3 = Task1.Skip(4);

            foreach (var item in Task3)
            {
                Console.WriteLine(item.Id);
            }

            Console.WriteLine();



            Console.ReadKey();
        }
    }
}
