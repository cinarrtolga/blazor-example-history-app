using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using HtmlAgilityPack;

namespace blazor_example_history_app.Core
{
    public class Crawler
    {
        public HtmlDocument GetHtmlPage(string requestUrl)
        {
            HttpClient httpClient = null;
            HtmlDocument htmlDocument = new HtmlDocument();

            httpClient = new HttpClient();
            var html = httpClient.GetStringAsync(requestUrl).Result;
            htmlDocument.LoadHtml(html);

            return htmlDocument;
        }

        public Dictionary<string, string> GetComponent(string requestUrl, string targetClass, string targetTag)
        {
            var htmlDocument = GetHtmlPage(requestUrl);
            Dictionary<string, string> ComponentList = new Dictionary<string, string>();

            var componentList = htmlDocument.DocumentNode
            .SelectNodes("//div[contains(@class, 'content-container')]")
            .Descendants("p").ToList();

            for (int nextObject = 0; nextObject < componentList.Count - 1; nextObject += 2)
            {
                if (!String.IsNullOrEmpty(componentList[nextObject].InnerText) &&
                !String.IsNullOrEmpty(componentList[nextObject + 1].InnerText))
                {
                    ComponentList.Add(componentList[nextObject + 1].InnerText, componentList[nextObject].InnerText);
                }
            }

            return ComponentList;
        }
    }
}