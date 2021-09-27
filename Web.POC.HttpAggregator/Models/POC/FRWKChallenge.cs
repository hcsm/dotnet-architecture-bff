using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.POC.HttpAggregator.Models.POC
{
    internal class FRWKChallenge
    {
        public int number { get; set; }
        public List<int> lstPrimeNumbers { get; set; }
        public List<int> lstDivisors { get; set; }
    }
}
