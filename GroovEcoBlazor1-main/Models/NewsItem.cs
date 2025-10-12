// Example of fetching and parsing an RSS feed
using System.Net.Http;
using System.Xml.Linq;

namespace GroovEcoBlazor1.Models
{
    public class NewsItem
    {
        public string Title { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}