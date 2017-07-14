using Google.Apis.Customsearch.v1;
using Google.Apis.Customsearch.v1.Data;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleSearch
{
    public class GoogleSearchEngine
    {
        const string apiKey = "AIzaSyBcylAP7HTwTpPgP1wdjHiDxz4rKxn4f0Q";
        const string searchEngineId = "016246175454578902491:exxvcxffxeq";
        
        public IList<string> Do(string term) {
            var customSearchService = new CustomsearchService(new BaseClientService.Initializer { ApiKey = apiKey });
            var listRequest = customSearchService.Cse.List(term);
            listRequest.Cx = searchEngineId;

            var result = new List<string>();
            
            IList<Result> paging = new List<Result>();

            var count = 0;
            while (paging != null) {
                listRequest.Start = count * 10 + 1;
                paging = listRequest.Execute().Items;
                if (paging != null) {
                    foreach (var item in paging) {
                        result.Add(item.FormattedUrl);
                    }
                }
                count++;
            }

            return result;
        }

    }
}
