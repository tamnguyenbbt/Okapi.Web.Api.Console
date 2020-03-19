using ExtSelenium.DomCore;

namespace Okapi.Web.Api.Console.Test.Models
{
    public class RecordRequestDTO
    {
        public string HtmlContent { get; set; }
        public DomFilter Filter { get; set; }
        public int FromIndex { get; set; }
        public int? Size { get; set; }
    }
}
