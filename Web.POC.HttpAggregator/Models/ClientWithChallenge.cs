using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.POC.HttpAggregator.Models.POC;
using Web.POC.HttpAggregator.Models.Services;

namespace Web.POC.HttpAggregator.Models
{
    internal class ClientWithChallenge
    {
        public int number { get; set; }
        public string Type { get; set; }
        public List<int> lstPrimeNumbers { get; set; }
        public List<int> lstDivisors { get; set; }
    }
}
