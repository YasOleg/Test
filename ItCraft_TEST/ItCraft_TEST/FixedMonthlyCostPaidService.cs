using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItCraft_TEST
{
    class FixedMonthlyCostPaidService : PaidService
    {
        public double MonthPay { get; set; }

        public override double calculateAverageMonthlyCosts(double MPay)
        {
            MPay = Costs;
            return MPay;
        }

        public FixedMonthlyCostPaidService(string monthId, string monthName, double monthCosts) 
            : base(monthId, monthName, monthCosts)
        {
            calculateAverageMonthlyCosts(MonthPay);
        }

        
    }
}
