using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItCraft_TEST
{
    class FixedHourlyCostPaidService : PaidService
    {
        public double HourPay { get; set; }

        public override double calculateAverageMonthlyCosts(double HPay)
        {
            HPay = 30 * 24 * Costs;
            HourPay = HPay;
            return HourPay;
           
        }

        public FixedHourlyCostPaidService(string hourId, string hourName, double hourCosts) 
            : base(hourId, hourName, hourCosts)
        {
             hourCosts = HourPay;
            calculateAverageMonthlyCosts(hourCosts);
          
        }

        
    }
}
