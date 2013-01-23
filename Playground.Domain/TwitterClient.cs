using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;
using System.Xml.Linq;

namespace Playground.Domain
{
    public class TwitterClient : ITwitterClient
    {
        public string Search(string searchWord)
        {
            if (searchWord == null)
                throw new ArgumentNullException("searchWord");

            if (string.IsNullOrWhiteSpace(searchWord))
                throw new ArgumentException("searchWord parameter cannot be empty or whitespace", "searchWord");

            var searchResultsXml = GetSearchResultsXml(searchWord);
            var searchResults = ConvertToObjects(searchResultsXml);

            return searchResultsXml;
        }

        private string GetSearchResultsXml(string searchWord)
        {
            var encodedSearch = HttpUtility.UrlEncode(searchWord);
            return new WebClient().DownloadString(
                String.Format(Properties.Settings.Default.TwitterSearchUrl, encodedSearch)
            );
        }

        private string ConvertToObjects(string searchResultsXml)
        {
            var xElement = XElement.Parse(searchResultsXml);
            var partNos =
                from entry in xElement.Descendants("entry")
                select (string)entry.Attribute("PartNumber");

            throw new NotImplementedException();
        }
    }
}
