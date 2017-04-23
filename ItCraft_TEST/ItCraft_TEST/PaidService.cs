using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItCraft_TEST
{
    abstract class PaidService
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Costs { get; set; }

        public PaidService(string id, string name, double costs)
        {
            Id = id;
            Name = name;
            Costs = costs;
        }
        public abstract double calculateAverageMonthlyCosts(double MPay);

    }
}
