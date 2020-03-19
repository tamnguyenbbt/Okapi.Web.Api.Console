using System.Collections.Generic;

namespace Okapi.Web.Api.Console.Test.Models
{
    public class ManagedXPathDTO
    {
        public string Id { get; set; }
        public string RecomendedLocator { get; set; }
        public List<string> PossibleLocators { get; set; }
        public ManagedXPathExtensionDTO ManagedXPathExtension { get; set; }
    }
}
