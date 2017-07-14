using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YahooSearch
{
    public class YahooSearchEngine
    {
        public Dictionary<string, string> Do(string term)
        {
            HtmlWeb w = new HtmlWeb();

            string search = $"https://en-maktoob.search.yahoo.com/search?p={term}";
            var hd = w.Load(search);

            var titles = hd.DocumentNode.QuerySelectorAll(".title a").Select(n => n.InnerText).ToList();
            var links = hd.DocumentNode.QuerySelectorAll(".title a").Select(n => n.OuterHtml).ToList();

            var result = new Dictionary<string, string>();

            for (int i = 0; i < titles.Count() - 1; i++)
            {
                var title = titles.ElementAt(i);
                string link = string.Empty;
                if (links.Count() > i) {
                    link = ParseHtml(links.ElementAt(i));
                    result[title] = link;
                }
            }

            return result;
        }

        private string ParseHtml(string html)
        {
            string regex = "href=\"(.*)\"";
            Match match = Regex.Match(html, regex);
            string link = "";
            if (match.Success)
            {
                link = match.Groups[1].Value;
                link = link.Substring(0, link.IndexOf('\"'));
            }
            return link;
        }
    }
}
