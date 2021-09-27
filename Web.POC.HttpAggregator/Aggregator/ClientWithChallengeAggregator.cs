using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Ocelot.Middleware;
using Ocelot.Multiplexer;
using Web.POC.HttpAggregator.Models;
using Web.POC.HttpAggregator.Models.POC;
using Web.POC.HttpAggregator.Models.Services;

namespace Web.POC.HttpAggregator.Aggregator
{
    public class ClientWithChallengeAggregator : IDefinedAggregator
    {        
        public Task<DownstreamResponse> Aggregate(List<HttpContext> responses)
        {            
            Client s1 = responses[0].Items.DownstreamResponse().Content.ReadAsAsync<Client>().Result;
            FRWKChallenge s2 = responses[1].Items.DownstreamResponse().Content.ReadAsAsync<FRWKChallenge>().Result;

            ClientWithChallenge result = new ClientWithChallenge();
            result.number = s2.number;
            result.Type = s1.Type;
            result.lstDivisors = s2.lstDivisors;
            result.lstPrimeNumbers = s2.lstPrimeNumbers;

            HttpResponseMessage response = new HttpResponseMessage();
            response.Content = new ObjectContent<ClientWithChallenge>(result, new JsonMediaTypeFormatter());

            return Task.FromResult(new DownstreamResponse(response));

        }
    }
}
