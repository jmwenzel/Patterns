using GoogleSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahooSearch;

namespace FacadeSearch
{
    public class Facade
    {
        public List<string> Search(string term)
        {
            var result = new List<string>();

            var google = new GoogleSearchEngine();
            IList<string> googleSearch = google.Do(term);
            result.AddRange(googleSearch);

            var yahoo = new YahooSearchEngine();
            IDictionary<string, string> yahooSearch = yahoo.Do(term);
            result.AddRange(yahooSearch.Values.ToList());

            return result; 

        }
    }
}
